
using DfosTira.Infrastructer;
using DfosTiraMigration.Models.GoMakeModels;
using DfosTiraMigration.Models.AwsModels.PriceListsModels;

using DfosTiraMigration.Models.GoMakeModels.PriceListsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using System.Data.Entity;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using NLog;

namespace DfosTiraMigration.Controllers
{
    public class HomeController : Controller
    {
        private Logger _logger = NLog.LogManager.GetCurrentClassLogger();
        public  ActionResult Index()
        {
            Thread thread = new Thread(migrate);
            thread.Start();
            return View();
        }
        public void migrateElinerProducts()
        {
            Guid PrintHouseId = Guid.Parse("1FAFA8F4-559E-4F57-ABE7-395EB1875F8B");
            var _oldContext = new Models.ElinerModels.ElinerDbContext();
            var _context = new GoMakeDbContext();

            var _oldGroups = _oldContext.ProductsGroups.AsNoTracking().ToList();
            var groupIdToGuid = new Dictionary<int, Guid>();
            _logger.Debug("ProductsGroups");
            for (int i = 0; i < _oldGroups.Count(); i++)
            {
                var item = _oldGroups[i];
                var newId = Guid.NewGuid();
                groupIdToGuid.Add(item.ID, newId);
                var g = new Models.GoMakeModels.Products.ProductsGroup
                {
                    ID = newId,
                    Name = item.Name,
                    PrintHouseId = PrintHouseId,
                };
                _context.ProductsGroups.Add(g);
            }

            var _oldMainProducts = _oldContext.MainProducts.AsNoTracking().ToList();
            var mainProductIdToGuid = new Dictionary<int, Guid>();
            _logger.Debug("MainProducts");
            for (int i = 0; i < _oldMainProducts.Count(); i++)
            {
                var item = _oldMainProducts[i];
                var newId = Guid.NewGuid();
                mainProductIdToGuid.Add(item.ID, newId);
                var mp = new Models.GoMakeModels.Products.MainProduct
                {
                    ID = newId,
                    Name = item.Name,
                    Code = item.Code,
                    PrintHouseId = PrintHouseId,
                };
                _context.MainProducts.Add(mp);
            }

            var _oldSubProducts = _oldContext.SubProducts.AsNoTracking().ToList();
            var SubProductIdToGuid = new Dictionary<int, Guid>();
            _logger.Debug("SubProducts");
            for (int i = 0; i < _oldSubProducts.Count(); i++)
            {
                var item = _oldSubProducts[i];
                var newId = Guid.NewGuid();
                SubProductIdToGuid.Add(item.ID, newId);
                var MainProductID = default(Guid);
                mainProductIdToGuid.TryGetValue(item.MainProductID, out MainProductID);
                var sp = new Models.GoMakeModels.Products.SubProduct
                {
                    ID = newId,
                    Name = item.Name,
                    MainProductID = MainProductID,
                    Description = item.Description,
                    ProductTypeID = item.ProductTypeID,
                    BelongTo = item.BelongTo,
                    IsSelectable = item.IsSelectable,
                    IsActive= item.IsActive,
                    Shortcut = item.Shortcut,
                };
                _context.SubProducts.Add(sp);
            }

            var _oldProductGroupRelations = _oldContext.ProductsGroupsRelations.AsNoTracking().ToList();
            _logger.Debug("ProductsGroupsRelations");
            for (int i = 0; i < _oldProductGroupRelations.Count(); i++)
            {
                var item = _oldProductGroupRelations[i];
                var newId = Guid.NewGuid();
                var ProductId = default(Guid);
                var GroupId = default(Guid);
                groupIdToGuid.TryGetValue(item.GroupID, out GroupId);
                SubProductIdToGuid.TryGetValue(item.ProductID, out ProductId);
                var pgr = new Models.GoMakeModels.Products.ProductsGroupsRelation
                {
                    ID = newId,
                    ProductID = ProductId,
                    GroupID = GroupId
                };
                _context.ProductsGroupsRelations.Add(pgr);
            }
            _context.SaveChanges();
        }
        void migrateBase()
        {
            Guid AwsPrintHouseId = Guid.Parse("B722CB5C-B7EF-408D-BA0E-0FD3997ABA2B");
            var _oldContext = new Models.AwsModels.AwsDbContext();
            var _context = new GoMakeDbContext();
            IMapper mapper = ConfigMapper().CreateMapper();

            _logger.Debug("client type");
            
            var oldClientTypes = _oldContext.ClientTypes.AsNoTracking().ToList();
            for (int i = 0; i < oldClientTypes.Count(); i++)
            {
                var newId = Guid.NewGuid();
              
                Models.GoMakeModels.ClientType clientType = new Models.GoMakeModels.ClientType
                {
                    ID = newId,
                    Name = oldClientTypes[i].Name,
                    IdenticalItemsDiscountId = 0,
                    PrintHouseId = AwsPrintHouseId,
                    DID = oldClientTypes[i].ID
                };
                _context.ClientTypes.Add(clientType);
            }
            //employees
            _logger.Debug("employees");
             var oldEmployees = _oldContext.Employees.AsNoTracking().ToList();
             //var employeIdToGuid = new Dictionary<int, Guid>();
             for (int i = 0; i < oldEmployees.Count(); i++)
             {
                 var newId = Guid.NewGuid();
                 var item = oldEmployees[i];
                 _logger.Debug(item.ID);
                 Models.GoMakeModels.Employee employee = new Models.GoMakeModels.Employee{
                     ID = newId,
                     Firstname = item.Firstname,
                     Lastname = item.Lastname,
                     Phone = item.Phone,
                     Email = item.Email,
                     IsActive = item.IsActive,
                     IsAgent = false,
                     MailService = "",
                     MailServicePassword="",
                     CreationDate =item.CreationDate,
                     PrintHouseId = AwsPrintHouseId,
                     DID = item.ID
                 };
                 _context.Employees.Add(employee);
             }

             //roles
             var oldRoles = _oldContext.Roles.AsNoTracking().ToList();
             var roleIdToGuid = new Dictionary<int, Guid>();
             _logger.Debug("roles");
             for (int i = 0; i < oldRoles.Count(); i++)
             {
                 var item = oldRoles[i];
                 var newId = Guid.NewGuid();
                 roleIdToGuid.Add(item.ID, newId);
                 Models.GoMakeModels.Role role = new Models.GoMakeModels.Role
                 {
                     ID = newId,
                     Name = item.Name,
                     Order = item.Order,
                     PrintHouseId = AwsPrintHouseId,
                    
                 };
                 _context.Roles.Add(role);
             }


            //users
             _logger.Debug("users");
             var UserIDToGuid = new Dictionary<int, Guid>();
             var oldUsers = _oldContext.Users.AsNoTracking().ToList();
             for (int i = 0; i < oldUsers.Count(); i++)
             {
                 var item = oldUsers[i];
                 var newId = Guid.NewGuid();
                 UserIDToGuid.Add(item.ID, newId);
                 Guid? employeeId = null;
                 //Guid? customerId = null;
                 Guid RoleId = default(Guid);
                 _logger.Debug(item.ID);
                 if (item.EmployeeId != null)
                 {
                     int empId = (int)item.EmployeeId;
                     employeeId = _context.Employees.Where(x => x.DID == empId).FirstOrDefault()?.ID;
                 }
                
                 roleIdToGuid.TryGetValue(item.RoleID, out RoleId);
                 Models.GoMakeModels.User newUser = new Models.GoMakeModels.User
                 {
                     ID = newId,
                     Username = item.Username,
                     Password = item.Password,
                     EmployeeId = employeeId,
                    // CustomerId = customerId,
                     ImageID = Guid.Parse("0AEB1F5B-C8B6-47F5-9FCB-0932D968C0C4"),
                     RoleID = RoleId,
                     IsActive = item.IsActive,
                     CreationDate = item.CreationDate,
                     PrintHouseId = AwsPrintHouseId,
                     DID = item.ID,

                 };
                 _context.Users.Add(newUser);
             }
            //main products
            _logger.Debug("main products");
            var MainProductIdToGuid = new Dictionary<int, Guid>();
            var oldMainProducts = _oldContext.MainProducts.AsNoTracking().ToList();
            for (int i = 0; i < oldMainProducts.Count(); i++)
            {
                var item = oldMainProducts[i];
                _logger.Debug(item.ID);
                var newId = Guid.NewGuid();
                MainProductIdToGuid.Add(item.ID, newId);
                var main = new Models.GoMakeModels.Products.MainProduct
                {
                    ID = newId,
                    Name = item.Name,
                    PrintHouseId = AwsPrintHouseId,
                    Code = item.Code,
                    DID = item.ID,
                };
                _context.MainProducts.Add(main);
            }

            //boards
            _logger.Debug("boards");
            var BoardIDtoGuid = new Dictionary<int, Guid>();
            var oldBoards = _oldContext.Boards.AsNoTracking().ToList();
            for (int i = 0; i < oldBoards.Count(); i++)
            {
                var item = oldBoards[i];
                _logger.Debug(item.ID);
                var newId = Guid.NewGuid();
                BoardIDtoGuid.Add(item.ID, newId);
                var board = new Models.GoMakeModels.Boards
                {
                    ID = newId,
                    Name = item.Name,
                    Description = item.Description,
                    PrintHouseId = AwsPrintHouseId,
                };
                _context.Boards.Add(board);
            }

            //boardcols
            _logger.Debug("boardcols");
            var BoardColsIdToGuid = new Dictionary<int, Guid>();
            var oldBoardColumns = _oldContext.BoardColumns.AsNoTracking().ToList();
            for (int i = 0; i < oldBoardColumns.Count(); i++)
            {
                var item = oldBoardColumns[i];
                _logger.Debug(item.ID);
                var newId = Guid.NewGuid();
                var boardId = default(Guid);
                BoardIDtoGuid.TryGetValue(item.BoardID, out boardId);
                BoardColsIdToGuid.Add(item.ID, newId);
                var col = new Models.GoMakeModels.BoardColumns
                {
                    ID = newId,
                    Name = item.Name,
                    BoardID = boardId,
                    Order = 0,
                    IsActive = true,
                    IsDeleted = false,
                    Tickets = item.Tickets,
                };
                _context.BoardColumns.Add(col);
            }

            //boardrows 
            _logger.Debug("boardrows");
            var BoardRowIdToGuid = new Dictionary<int, Guid>();
            var oldBoardRows = _oldContext.BoardRows.AsNoTracking().ToList();
            for (int i = 0; i < oldBoardRows.Count(); i++)
            {
                var item = oldBoardRows[i];
                _logger.Debug(item.ID);
                var newId = Guid.NewGuid();
                var boardId = default(Guid);
                BoardIDtoGuid.TryGetValue(item.BoardID, out boardId);
                BoardRowIdToGuid.Add(item.ID, newId);
                var row = new Models.GoMakeModels.BoardRows
                {
                    ID = newId,
                    Name = item.Name,
                    BoardID = boardId,
                    Order = 0,
                    IsActive = true,
                    IsDeleted = false,
                };
                _context.BoardRows.Add(row);
            }

            //sub products
            _logger.Debug("sub products");
            var SubProductIdToGuid = new Dictionary<int, Guid>();
            var oldSubProducts = _oldContext.SubProducts.AsNoTracking().ToList();
            for (int i = 0; i < oldSubProducts.Count(); i++)
            {
                var item = oldSubProducts[i];
                _logger.Debug(item.ID);
                var newId = Guid.NewGuid();
                SubProductIdToGuid.Add(item.ID, newId);
                var mainProductId = default(Guid);
                Guid? boardID = null;
                Guid? columnID = null;
                Guid? rowID = null;
                MainProductIdToGuid.TryGetValue(item.MainProductID, out mainProductId);
                if (item.BoardID != null)
                {
                    Guid tmp = default(Guid);
                    BoardIDtoGuid.TryGetValue((int)item.BoardID, out tmp);
                    if (tmp != default(Guid))
                        boardID = tmp;
                }
                if (item.ColumnID != null)
                {
                    Guid tmp = default(Guid);
                    BoardColsIdToGuid.TryGetValue((int)item.ColumnID, out tmp);
                    if (tmp != default(Guid))
                        columnID = tmp;
                }
                if (item.RowID != null)
                {
                    Guid tmp = default(Guid);
                    BoardRowIdToGuid.TryGetValue((int)item.RowID, out tmp);
                    if (tmp != default(Guid))
                        rowID = tmp;
                }

                var sub = new Models.GoMakeModels.Products.SubProduct
                {
                    ID = newId,
                    Name = item.Name,
                    MainProductID = mainProductId,
                    Description = item.Description,
                    ProductTypeID = 1,
                    BelongTo = item.BelongTo,
                    IsSelectable = item.IsSelectable,
                    IsActive = item.IsActive,
                    Shortcut = false,
                    BoardID = boardID,
                    ColumnID = columnID,
                    RowID = rowID,

                };
                _context.SubProducts.Add(sub);
            }


            var oldShatnsim = _oldContext.Shtansims.AsNoTracking().ToList();
            for (int i = 0; i < oldShatnsim.Count(); i++)
            {
                var item = oldShatnsim[i];
                var newId = Guid.NewGuid();
                Guid? ImgId = null;
                if (item.ImageID != null)
                {
                    var Image = _oldContext.Images.Where(x => x.ID == item.ImageID).FirstOrDefault();
                    if(Image != null)
                    {
                        var newImg = new Models.GoMakeModels.Image {
                            ID = Guid.NewGuid(),
                            Path = Image.Path,
                        };
                        _context.Images.Add(newImg);
                        ImgId = newImg.ID;
                    }
                }
               
                var shtans = mapper.Map<Models.GoMakeModels.Shtansim>(item);
                shtans.ID = newId;
                shtans.DID = item.ID;
                shtans.ImageID = ImgId;
                _context.Shtansims.Add(shtans);
            }
            _logger.Debug("SaveChanges");
            _context.SaveChanges();
            _logger.Debug("END");
        }

        void cc()
        {
            try
            {
                Guid AwsPrintHouseId = Guid.Parse("B722CB5C-B7EF-408D-BA0E-0FD3997ABA2B");
                var _oldContext = new Models.AwsModels.AwsDbContext();
                var _context = new GoMakeDbContext();
                IMapper mapper = ConfigMapper().CreateMapper();
                //Contacts
                _logger.Debug("Contacts");
                var oldContacts = _oldContext.Contacts.AsNoTracking().ToList();
                for (int i = 0; i < oldContacts.Count(); i++)
                {
                    var item = oldContacts[i];
                    if (_context.Contacts.Any(x => x.DID == item.ID) == false)
                    {
                        _logger.Debug(item.ID);
                        var newId = Guid.NewGuid();
                        var clientId = default(Guid);
                        var client = _context.Clients.FirstOrDefault(x => x.DID == item.ClientId);

                        if (client != null)
                        {
                            clientId = client.ID;
                            var contact = new Models.GoMakeModels.Contact
                            {
                                ID = newId,
                                ClientId = clientId,
                                SapContactId = item.SapContactId,
                                FirstName = item.FirstName,
                                LastName = item.LastName,
                                Title = item.Title,
                                Position = item.Position,
                                Address = item.Address,
                                Tel1 = item.Tel1,
                                Tel2 = item.Tel2,
                                Phone = item.Phone,
                                Fax = item.Fax,
                                Mail = item.Mail,
                                DID = item.ID,
                            };
                            _context.Contacts.Add(contact);
                        }

                    }

                }

                _logger.Debug("SaveChanges");
                _context.SaveChanges();
                //address
                _logger.Debug("address");
                // var AddressIDtoGuid = new Dictionary<int, Guid>();
                var oldAddresses = _oldContext.Addresses.AsNoTracking().ToList();
                for (int i = 0; i < oldAddresses.Count(); i++)
                {
                    var item = oldAddresses[i];
                    if (_context.Addresses.Any(x => x.DID == item.ID) == false)
                    {
                        _logger.Debug(item.ID);
                        var newId = Guid.NewGuid();
                        var clientId = default(Guid);
                        var client = _context.Clients.FirstOrDefault(x => x.DID == item.ClientId);
                        if (client != null)
                        {
                            clientId = client.ID;
                            var address = new Models.GoMakeModels.Address
                            {
                                ID = newId,
                                ClientId = clientId,
                                Address1 = item.Address1,
                                Address2 = item.Address2,
                                Address3 = item.Address3,
                                Street = item.Street,
                                StreetNumber = item.StreetNumber,
                                Block = item.Block,
                                City = item.City,
                                ZIPCode = item.ZIPCode,
                                County = item.County,
                                State = item.State,
                                Country = item.Country,
                                AddressType = "S",
                                DID = item.ID,
                            };
                            _context.Addresses.Add(address);
                        }

                    }

                }



                _logger.Debug("SaveChanges");
                _context.SaveChanges();
                _logger.Debug("end");
            }
            catch(Exception EX)
            {
                _logger.Debug(EX.Message);
            }
        }
        public void migrate()
        {

            Guid AwsPrintHouseId = Guid.Parse("B722CB5C-B7EF-408D-BA0E-0FD3997ABA2B");
            var _oldContext = new Models.AwsModels.AwsDbContext();
            var _context = new GoMakeDbContext();
            IMapper mapper = ConfigMapper().CreateMapper();
           
            


            DateTime start = new DateTime(2021, 03, 26);
            DateTime end = new DateTime(2021, 03, 25);
            var orders = _oldContext.Orders.Where(x => x.CreationDate <= start && x.CreationDate >= end).Take(10).Include(x=>x.OrderItems).AsEnumerable();
            var quotes = _oldContext.Quotes.Where(x => x.CreationDate <= start && x.CreationDate >= end).Take(10).Include(x=>x.PriceListItems).AsEnumerable();
           
           var _oldOrderItems = _oldContext.OrderItems.Where(x => orders.Any(y=>y.ID == x.OrderID)).AsEnumerable();
            var _oldQuoteItems = _oldContext.QuoteItems.Where(x => quotes.Any(y => y.ID == x.QuoteID)).AsEnumerable();
          
            //DigitalItemValues
            _logger.Debug("DigitalItemValues");
            //var DigitalItemIdToGuid = new Dictionary<int, Guid>();
            var oldDigitalItemValues = _oldContext.DigitalItemValues.Where(x=> _oldOrderItems.Any(y=>y.DigitalPriceListID == x.ID ) || _oldQuoteItems.Any(y => y.DigitalPriceListID == x.ID)).AsNoTracking().ToList();
            for(int i = 0; i < oldDigitalItemValues.Count(); i++)
            {
                var item = oldDigitalItemValues[i];
                if(_context.DigitalItemValues.Any(x=>x.DID == item.ID ) == false)
                {
                    _logger.Debug(item.ID);
                    var newId = Guid.NewGuid();
                    // DigitalItemIdToGuid.Add(item.ID, newId);
                    var digital = mapper.Map<Models.GoMakeModels.PriceListsModels.DigitalItemValue>(item);
                    digital.ID = newId;
                    digital.DID = item.ID;
                    if (item.SetsQuantity != null)
                        digital.SetsQuantity = double.Parse(item.SetsQuantity);
                    else
                        digital.SetsQuantity = null;
                    _context.DigitalItemValues.Add(digital);
                }
                
            }


            var _oldBidItemValues = _oldContext.BidItemValues.Where(x => _oldOrderItems.Any(y => y.BidPriceListID == x.ID) || _oldQuoteItems.Any(y => y.BidPriceListID == x.ID)).AsEnumerable();
            //BidItemValueShtansim
            _logger.Debug("BidItemValueShtansim");
            var oldBidItemValueShtansim = _oldContext.BidItemValueShtansim.Where(x=> _oldBidItemValues.Any(y=> x.BidItemValues.Any(z=>z.ID == y.ID))).AsNoTracking().ToList();
            for (int i = 0; i < oldBidItemValueShtansim.Count(); i++)
            {
                var item = oldBidItemValueShtansim[i];
                if (_context.BidItemValueShtansim.Any(x => x.DID == item.ID) == false)
                {
                    _logger.Debug(item.ID);
                    var newId = Guid.NewGuid();
                    //BidItemShtansimIdToGuid.Add(item.ID, newId);
                    var bidShtans = mapper.Map<Models.GoMakeModels.BidItemValueShtansim>(item);
                    bidShtans.ID = newId;
                    bidShtans.DID = item.ID;
                    _context.BidItemValueShtansim.Add(bidShtans);
                }
                    
            }

            //BidItemValues
            _logger.Debug("BidItemValues");
            var oldBidItemValues = _oldBidItemValues.ToList();

            for (int i = 0; i < oldBidItemValues.Count(); i++)
            {
                var item = oldBidItemValues[i];
                if (_context.BidItemValues.Any(x => x.DID == item.ID) == false)
                {
                    _logger.Debug(item.ID);
                    var newId = Guid.NewGuid();
                    Guid? ShtansID = _context.BidItemValueShtansim.FirstOrDefault(x => x.DID == item.ShtansID)?.ID;
                    var bid = mapper.Map<Models.GoMakeModels.PriceListsModels.BidItemValue>(item);
                    bid.ID = newId;
                    bid.DID = item.ID;
                    bid.ShtansID = ShtansID;
                    if (string.IsNullOrEmpty(item.White))
                        bid.White = false;
                    else
                        bid.White = true;
                    _context.BidItemValues.Add(bid);
                }
                    
            }

            //EnvelopesItemValues
            _logger.Debug("EnvelopesItemValues");
            var oldEnvelopesItemValues = _oldContext.EnvelopesItemValues.Where(x => _oldOrderItems.Any(y => y.EnvelopesPriceListID == x.ID) || _oldQuoteItems.Any(y => y.EnvelopesPriceListID == x.ID)).AsNoTracking().ToList();
            for (int i = 0; i < oldEnvelopesItemValues.Count(); i++)
            {
                var item = oldEnvelopesItemValues[i];

                if (_context.EnvelopesItemValues.Any(x => x.DID == item.ID) == false)
                {
                    _logger.Debug(item.ID);
                    var newId = Guid.NewGuid();
                    var envelope = mapper.Map<Models.GoMakeModels.PriceListsModels.EnvelopesItemValue>(item);
                    envelope.ID = newId;
                    envelope.DID = item.ID;
                    _context.EnvelopesItemValues.Add(envelope);
                }
                   
            }

            //BooksItemValues
            _logger.Debug("BooksItemValues");
            var oldBooksItemValues = _oldContext.BooksItemValues.Where(x => _oldOrderItems.Any(y => y.BooksPriceListID == x.ID) || _oldQuoteItems.Any(y => y.BooksPriceListID == x.ID)).AsNoTracking().ToList();
            for (int i = 0; i < oldBooksItemValues.Count(); i++)
            {
                var item = oldBooksItemValues[i];
                if (_context.BooksItemValues.Any(x => x.DID == item.ID) == false)
                {
                    _logger.Debug(item.ID);
                    var newId = Guid.NewGuid();
                    var book = mapper.Map<Models.GoMakeModels.PriceListsModels.BooksItemValue>(item);
                    book.ID = newId;
                    book.DID = item.ID;
                    _context.BooksItemValues.Add(book);
                }
                
            }
            _context.SaveChanges();
            var oldBooksItemValuesQry = _oldContext.BooksItemValues.Where(x => _oldOrderItems.Any(y => y.BooksPriceListID == x.ID) || _oldQuoteItems.Any(y => y.BooksPriceListID == x.ID)).AsEnumerable();
            _logger.Debug("Covers");
            var oldCovers = _oldContext.Covers.Where(x=> oldBooksItemValuesQry.Any(y=>y.ID == x.BooksPriceListID)).AsNoTracking().ToList();
            for (int i = 0; i < oldCovers.Count(); i++)
            {
                var item = oldCovers[i];
                if (_context.Covers.Any(x => x.DID == item.ID) == false)
                {
                    _logger.Debug(item.ID);
                    var newId = Guid.NewGuid();
                    var bookId = _context.BooksItemValues.FirstOrDefault(x => x.DID == item.BooksPriceListID).ID;
                    var cover = mapper.Map<Models.GoMakeModels.PriceListsModels.Cover>(item);
                    cover.ID = newId;
                    cover.BooksPriceListID = bookId;
                    cover.DID = item.ID;
                    _context.Covers.Add(cover);
                }

            }

            _logger.Debug("IntireColumns");
            var oldIntireColumns = _oldContext.IntireColumns.Where(x => oldBooksItemValuesQry.Any(y => y.ID == x.BooksPriceListID)).AsNoTracking().ToList();
            for (int i = 0; i < oldCovers.Count(); i++)
            {
                var item = oldIntireColumns[i];
                if (_context.IntireColumns.Any(x => x.DID == item.ID) == false)
                {
                    _logger.Debug(item.ID);
                    var newId = Guid.NewGuid();
                    var bookId = _context.BooksItemValues.FirstOrDefault(x => x.DID == item.BooksPriceListID).ID;
                    var cover = mapper.Map<Models.GoMakeModels.PriceListsModels.IntireColumn>(item);
                    cover.ID = newId;
                    cover.BooksPriceListID = bookId;
                    cover.DID = item.ID;
                    _context.IntireColumns.Add(cover);
                }

            }

            //ProductsItemValues
            _logger.Debug("ProductsItemValues");
            var oldProductsItemValues = _oldContext.ProductsItemValues.Where(x => _oldOrderItems.Any(y => y.ProductsPriceListID == x.ID) || _oldQuoteItems.Any(y => y.ProductsPriceListID == x.ID)).AsNoTracking().ToList();
            for (int i = 0; i < oldProductsItemValues.Count(); i++)
            {
                var item = oldProductsItemValues[i];
                if (_context.ProductsItemValues.Any(x => x.DID == item.ID) == false)
                {
                    _logger.Debug(item.ID);
                    var newId = Guid.NewGuid();
                    var product = mapper.Map<Models.GoMakeModels.PriceListsModels.ProductsItemValue>(item);
                    product.ID = newId;
                    product.DID = item.ID;
                    _context.ProductsItemValues.Add(product);
                }
                    
            }

            //PrintingItemValues
            _logger.Debug("PrintingItemValues");
            var oldPrintingItemValues = _oldContext.PrintingItemValues.Where(x => _oldOrderItems.Any(y => y.PrintingPriceListID == x.ID) || _oldQuoteItems.Any(y => y.PrintingPriceListID == x.ID)).AsNoTracking().ToList();
            for (int i = 0; i < oldPrintingItemValues.Count(); i++)
            {
                var item = oldPrintingItemValues[i];
                if (_context.PrintingItemValues.Any(x => x.DID == item.ID) == false)
                {
                    _logger.Debug(item.ID);
                    var newId = Guid.NewGuid();
                    var printing = new Models.GoMakeModels.PriceListsModels.PrintingItemValue
                    {
                        ID = newId,
                        Printing = item.Printing,
                        Sticker = item.Sticker,
                        Shemshonet = item.Shemshonet,
                        Cutting = item.Cutting,
                        Lamination = item.Laminated,
                        Application = string.IsNullOrEmpty(item.Application) ? false : true,

                    };
                    printing.ID = newId;
                    printing.DID = item.ID;
                    _context.PrintingItemValues.Add(printing);
                }
                    
            }
            _context.SaveChanges();
            var oldPrintingItemValueQry = _oldContext.PrintingItemValues.Where(x => _oldOrderItems.Any(y => y.PrintingPriceListID == x.ID) || _oldQuoteItems.Any(y => y.PrintingPriceListID == x.ID)).AsEnumerable();
            //PrintingItemValues
            _logger.Debug("PrintingItemWorks");
            var oldPrintingItemWorks = _oldContext.PrintingItemWorks.Where(x => oldPrintingItemValueQry.Any(y => y.ID == x.PrintingPriceListID)).AsNoTracking().ToList();
            for (int i = 0; i < oldPrintingItemWorks.Count(); i++)
            {
                var item = oldPrintingItemWorks[i];
                if (_context.PrintingItemWorks.Any(x => x.DID == item.ID) == false)
                {
                    _logger.Debug(item.ID);
                    var newId = Guid.NewGuid();
                    var PrintingPriceListID = _context.PrintingItemValues.FirstOrDefault(x => x.DID == item.PrintingPriceListID).ID;
                    var printing = new Models.GoMakeModels.PriceListsModels.PrintingItemWork
                    {
                        ID = newId,
                        WorkName = item.WorkName,
                        Quantity = item.Quantity,
                        Width = item.Width,
                        Height = item.Height,
                        DID = item.ID,
                        PrintingPriceListID = PrintingPriceListID
                    };
                    printing.ID = newId;
                    printing.DID = item.ID;
                    _context.PrintingItemWorks.Add(printing);
                }

            }

            //ShelfProductsItemValues
            _logger.Debug("ShelfProductsItemValues");
          
            var oldShelfProductsItemValues = _oldContext.ShelfProductsItemValues.Where(x => _oldOrderItems.Any(y => y.ShelfProductsPriceListID == x.ID) || _oldQuoteItems.Any(y => y.ShelfProductsPriceListID == x.ID)).AsNoTracking().ToList();
            for (int i = 0; i < oldShelfProductsItemValues.Count(); i++)
            {
                var item = oldShelfProductsItemValues[i];
                if (_context.ShelfProductsItemValues.Any(x => x.DID == item.ID) == false)
                {
                    _logger.Debug(item.ID);
                    var newId = Guid.NewGuid();
                    var shelf = mapper.Map<Models.GoMakeModels.PriceListsModels.ShelfProductsItemValue>(item);
                    shelf.ID = newId;
                    shelf.DID = item.ID;
                    _context.ShelfProductsItemValues.Add(shelf);
                }
                    
               
            }

            //NotepadItemValues
            _logger.Debug("NotepadItemValues");
            var oldNotepadItemValues = _oldContext.NotepadItemValues.Where(x => _oldOrderItems.Any(y => y.NotepadPriceListID == x.ID) || _oldQuoteItems.Any(y => y.NotepadPriceListID == x.ID)).AsNoTracking().ToList();
            for (int i = 0; i < oldNotepadItemValues.Count(); i++)
            {
                var item = oldNotepadItemValues[i];
                if (_context.NotepadItemValues.Any(x => x.DID == item.ID) == false)
                {
                    _logger.Debug(item.ID);
                    var newId = Guid.NewGuid();
                    var notepad = mapper.Map<Models.GoMakeModels.PriceListsModels.NotepadItemValue>(item);
                    notepad.ID = newId;
                    notepad.DID = item.ID;
                    _context.NotepadItemValues.Add(notepad);
                }
                   
            }

           
         
            //quotes
            _logger.Debug("quotes");
            var oldQuotes = quotes.ToList();
            for(int i = 0; i < oldQuotes.Count(); i++)
            {
                var item = oldQuotes[i];
                if (_context.Quotes.Any(x => x.DID == item.ID) == false)
                {
                    _logger.Debug(item.ID);
                    var newId = Guid.NewGuid();

                    var userId = default(Guid);
                    userId = _context.Users.FirstOrDefault(x => x.DID == item.UserID).ID;
                    // UserIDToGuid.TryGetValue(item.UserID, out userId);

                    var customerId = default(Guid);
                    customerId = _context.Clients.FirstOrDefault(x => x.DID == item.CustomerID).ID;
                    Guid? contactId = null;
                    if (item.ContactID != null)
                    {
                        contactId = _context.Contacts.FirstOrDefault(x => x.DID == item.ContactID)?.ID;
                    }
                    Guid? addressId = null;
                    if (item.AddressID != null)
                    {
                        addressId = _context.Addresses.FirstOrDefault(x => x.DID == item.AddressID)?.ID;
                    }
                    var quote = mapper.Map<Models.GoMakeModels.PriceListsModels.Quote>(item);
                    quote.ID = newId;
                    quote.UserID = userId;
                    quote.CustomerID = customerId;
                    quote.ContactID = contactId;
                    quote.AddressID = addressId;
                    quote.PrintHouseId = AwsPrintHouseId;
                    quote.DID = item.ID;
                    _context.Quotes.Add(quote);
                 
                }
                  
            }
            _context.SaveChanges();

            _logger.Debug("QuoteItems");
            var oldQuoteItems = _oldContext.QuoteItems.Where(x => quotes.Any(y => y.ID == x.QuoteID)).AsNoTracking().ToList();
            for (int i = 0; i < oldQuoteItems.Count(); i++)
            {
                var item = oldQuoteItems[i];
                if (_context.QuoteItems.Any(x => x.DID == item.ID) == false)
                {
                    _logger.Debug(item.ID);
                    var newId = Guid.NewGuid();

                    var quoteID = _context.Quotes.FirstOrDefault(x=>x.DID == item.QuoteID).ID;
                    var mainProductId = default(Guid);
                    Guid? forItemId = _context.QuoteItems.FirstOrDefault(x => x.DID == item.ForItemID)?.ID;
                    mainProductId = _context.SubProducts.FirstOrDefault(x => x.DID == item.ProductID).ID;

                    Guid? digialId = _context.DigitalItemValues.FirstOrDefault(x => x.DID == item.DigitalPriceListID)?.ID;
                    Guid? bidId = _context.BidItemValues.FirstOrDefault(x => x.DID == item.DigitalPriceListID)?.ID;
                    Guid? envId = _context.EnvelopesItemValues.FirstOrDefault(x => x.DID == item.DigitalPriceListID)?.ID;
                    Guid? notepadId = _context.NotepadItemValues.FirstOrDefault(x => x.DID == item.DigitalPriceListID)?.ID;
                    Guid? booksId = _context.BooksItemValues.FirstOrDefault(x => x.DID == item.DigitalPriceListID)?.ID;
                    Guid? productId = _context.ProductsItemValues.FirstOrDefault(x => x.DID == item.DigitalPriceListID)?.ID;
                    Guid? printingId = _context.PrintingItemValues.FirstOrDefault(x => x.DID == item.DigitalPriceListID)?.ID;
                    Guid? shelfId = _context.ShelfProductsItemValues.FirstOrDefault(x => x.DID == item.DigitalPriceListID)?.ID;


                    var quoteItem = new Models.GoMakeModels.PriceListsModels.QuoteItem
                    {
                        ID = newId,
                        QuoteID = quoteID,
                        ProductID = mainProductId,
                        Quantity = item.Quantity,
                        FinalPrice = item.FinalPrice,
                        Price = item.Price,
                        DigitalPriceListID = digialId,
                        BidPriceListID = bidId,
                        EnvelopesPriceListID = envId,
                        NotepadPriceListID = notepadId,
                        BooksPriceListID = booksId,
                        ProductsPriceListID = productId,
                        PrintingPriceListID = printingId,
                        ShelfProductsPriceListID = shelfId,
                        MissionNumber = item.MissionNumber,
                        discount = item.discount,
                        ForItemID = forItemId,
                        Content = item.Content,
                        PrintingNotes = item.PrintingNotes,
                        GraphicNotes = item.GraphicNotes,
                        WorkName = item.WorkName,
                        IsNeedGraphics = item.IsNeedGraphics,
                        IsOO = item.IsOO,
                        DID = item.ID
                    };
                    _context.QuoteItems.Add(quoteItem);
                }

            }
            //orders
            _logger.Debug("orders");
            var oldOrders = orders.ToList();
            for (int i = 0; i < oldOrders.Count(); i++)
            {
                var item = oldOrders[i];
                if (_context.Orders.Any(x => x.DID == item.ID) == false)
                {
                    _logger.Debug(item.ID);
                    var newId = Guid.NewGuid();

                    var userId = _context.Users.FirstOrDefault(x => x.DID == item.UserID).ID;
                    var customerId = _context.Clients.FirstOrDefault(x => x.DID == item.CustomerID).ID;
                    Guid? contactId = _context.Contacts.FirstOrDefault(x => x.DID == item.ContactID)?.ID;

                    Guid? addressId = _context.Addresses.FirstOrDefault(x => x.DID == item.AddressID)?.ID;

                    var order = mapper.Map<Models.GoMakeModels.PriceListsModels.Order>(item);
                    order.ID = newId;
                    order.UserID = userId;
                    order.CustomerID = customerId;
                    order.ContactID = contactId;
                    order.AddressID = addressId;
                    order.PrintHouseId = AwsPrintHouseId;
                    order.DID = item.ID;
                    _context.Orders.Add(order);
                 
                }
                    
            }
            _context.SaveChanges();
            //orderItems
            _logger.Debug("orderItems");
            var oldOrderItems = _oldContext.OrderItems.Where(x => orders.Any(y => y.ID == x.OrderID)).AsNoTracking().ToList();
            for (int i = 0; i < oldOrderItems.Count(); i++)
            {
                var item = oldOrderItems[i];
                if (_context.OrderItems.Any(x => x.DID == item.ID) == false)
                {
                    _logger.Debug(item.ID);
                    var newId = Guid.NewGuid();
                    var orderID = _context.Orders.FirstOrDefault(x=>x.DID == item.OrderID).ID;
                    var SUBProductId = _context.SubProducts.FirstOrDefault(x => x.DID == item.ProductID).ID;
                    Guid? forItemId = _context.OrderItems.FirstOrDefault(x => x.DID == item.ForItemID)?.ID; ;

                    Guid? digialId = _context.DigitalItemValues.FirstOrDefault(x => x.DID == item.DigitalPriceListID)?.ID;
                    Guid? bidId = _context.BidItemValues.FirstOrDefault(x => x.DID == item.DigitalPriceListID)?.ID;
                    Guid? envId = _context.EnvelopesItemValues.FirstOrDefault(x => x.DID == item.DigitalPriceListID)?.ID;
                    Guid? notepadId = _context.NotepadItemValues.FirstOrDefault(x => x.DID == item.DigitalPriceListID)?.ID;
                    Guid? booksId = _context.BooksItemValues.FirstOrDefault(x => x.DID == item.DigitalPriceListID)?.ID;
                    Guid? productId = _context.ProductsItemValues.FirstOrDefault(x => x.DID == item.DigitalPriceListID)?.ID;
                    Guid? printingId = _context.PrintingItemValues.FirstOrDefault(x => x.DID == item.DigitalPriceListID)?.ID;
                    Guid? shelfId = _context.ShelfProductsItemValues.FirstOrDefault(x => x.DID == item.DigitalPriceListID)?.ID;



                    var orderItem = new Models.GoMakeModels.PriceListsModels.OrderItem
                    {
                        ID = newId,
                        OrderID = orderID,
                        ProductID = SUBProductId,
                        Quantity = item.Quantity,
                        FinalPrice = item.FinalPrice,
                        Price = item.Price,
                        DigitalPriceListID = digialId,
                        BidPriceListID = bidId,
                        EnvelopesPriceListID = envId,
                        NotepadPriceListID = notepadId,
                        BooksPriceListID = booksId,
                        ProductsPriceListID = productId,
                        PrintingPriceListID = printingId,
                        ShelfProductsPriceListID = shelfId,
                        MissionNumber = item.MissionNumber,
                        discount = item.discount,
                        ForItemID = forItemId,
                        Content = item.Content,
                        PrintingNotes = item.PrintingNotes,
                        GraphicNotes = item.GraphicNotes,
                        WorkName = item.WorkName,
                        IsNeedGraphics = item.IsNeedGraphics,
                        IsOO = item.IsOO,
                        DID = item.ID
                    };

                    _context.OrderItems.Add(orderItem);
                }

            }
            _context.SaveChanges();
            //board missions
            _logger.Debug("board missions");
            var BoardMissionIdToGuid = new Dictionary<int, Guid>();
            var bordmiss = _oldContext.BoardMissions.Where(x => _oldOrderItems.Any(y => y.ID == x.OrderItemID)).AsEnumerable();
            var oldBoardMissions = bordmiss.ToList();
            for (int i = 0; i < oldBoardMissions.Count(); i++)
            {
                var item = oldBoardMissions[i];
                if (_context.BoardMissions.Any(x => x.DID == item.ID) == false)
                {
                    _logger.Debug(item.ID);
                    var newId = Guid.NewGuid();
                    BoardMissionIdToGuid.Add(item.ID, newId);
                    Guid boardID = _context.Boards.FirstOrDefault(x => x.DID == item.BoardID).ID;
                    Guid columnID = _context.BoardColumns.FirstOrDefault(x => x.DID == item.ColumnID).ID;
                    Guid rowID = _context.BoardRows.FirstOrDefault(x => x.DID == item.RowID).ID;
                    Guid? orderItemId = _context.OrderItems.FirstOrDefault(x => x.DID == item.OrderItemID)?.ID;



                    var mission = new Models.GoMakeModels.BoardMissions
                    {
                        ID = newId,
                        Number = item.Number,
                        Name = item.Name,
                        Description = item.Description,
                        BoardID = boardID,
                        ColumnID = columnID,
                        RowID = rowID,
                        OrderItemID = orderItemId,
                        SourceIdentity = item.SourceIdentity,
                        DueDate = item.DueDate,
                        isReady = item.isReady,
                        isDynamic = item.isDynamic,
                        Priority = item.Priority,
                        DID = item.ID
                    };
                    _context.BoardMissions.Add(mission);
                }
                  
                    
            }
            _context.SaveChanges();


            //board missions
            /*  _logger.Debug("GeneralUsersLogs");
              var GeneralUsersLogsIdToGuid = new Dictionary<int, Guid>();
              var oldGeneralUsersLogs = _oldContext.GeneralUsersLogs.ToList();
              for (int i = 0; i < oldGeneralUsersLogs.Count(); i++)
              {
                  var item = oldGeneralUsersLogs[i];
                  if (_context.GeneralUsersLogs.Any(x => x.DID == item.ID) == false)
                  {
                      var newId = Guid.NewGuid();

                      Guid userId = _context.Users.FirstOrDefault(x => x.DID == item.UserId).ID;
                      Models.GoMakeModels.Logs.GeneralUsersLog log = new Models.GoMakeModels.Logs.GeneralUsersLog
                      {
                          ID = newId,
                          UserId = userId,
                          LogTypeId = item.LogTypeId,
                          Description = item.Description,
                          CreationDate = item.CreationDate,
                          DID = item.ID,
                          PrintHouseId = AwsPrintHouseId
                      };
                      _context.GeneralUsersLogs.Add(log);
                  }


              }
            */
            _logger.Debug("OrderItemFiles");
            var oldOrderItemFiles = _oldContext.OrderItemFiles.Where(x => _oldOrderItems.Any(y => y.ID == x.OrderItemId)).AsNoTracking().ToList();
            for(int i =0;i< oldOrderItemFiles.Count(); i++)
            {
                var item = oldOrderItemFiles[i];
                if (_context.OrderItemFiles.Any(x => x.DID == item.ID) == false)
                {
                    var newId = Guid.NewGuid();
                    _logger.Debug(item.ID);
                    Guid orderItemId = _context.OrderItems.FirstOrDefault(x => x.DID == item.OrderItemId).ID;
                    Models.GoMakeModels.OrderItemFile log = new Models.GoMakeModels.OrderItemFile
                    {
                        ID = newId,
                        OrderItemId = orderItemId,
                        FileName = item.FileName,
                        FilePath = item.FilePath,
                        FileLocalPath = item.FileLocalPath,
                        FileTypeId = item.FileTypeId,
                    };
                    _context.OrderItemFiles.Add(log);
                }
            }
            _logger.Debug("OrderLogs");
            var oldOrderLogs = _oldContext.OrderLogs.Where(x=> orders.Any(y=>y.ID == x.OrderId)).AsNoTracking().ToList();
            for (int i = 0; i < oldOrderLogs.Count(); i++)
            {
                var item = oldOrderLogs[i];
                if (_context.OrderLogs.Any(x => x.DID == item.ID) == false)
                {
                    var newId = Guid.NewGuid();

                    _logger.Debug(item.ID);
                    Guid userId = _context.Users.FirstOrDefault(x => x.DID == item.UserId).ID;
                    Guid orderId = _context.Orders.FirstOrDefault(x => x.DID == item.OrderId).ID;
                    Models.GoMakeModels.Logs.OrdersLog log = new Models.GoMakeModels.Logs.OrdersLog
                    {
                        ID = newId,
                        UserId = userId,
                        LogTypeId = item.LogTypeId,
                        OrderId = orderId,
                        Description = item.Description,
                        CreationDate = item.CreationDate,
                        DID = item.ID,
                        PrintHouseId = AwsPrintHouseId
                    };
                    _context.OrderLogs.Add(log);
                }
                    

            }

            _logger.Debug("QuotesLogs");
            var oldQuotesLogs = _oldContext.QuotesLogs.Where(x => quotes.Any(y => y.ID == x.QuoteId)).AsNoTracking().ToList();
            for (int i = 0; i < oldQuotesLogs.Count(); i++)
            {
                var newId = Guid.NewGuid();
                var item = oldQuotesLogs[i];
                if (_context.QuotesLogs.Any(x => x.DID == item.ID) == false)
                {
                    _logger.Debug(item.ID);
                    Guid userId = _context.Users.FirstOrDefault(x => x.DID == item.UserId).ID;
                    Guid quoteId = _context.Quotes.FirstOrDefault(x => x.DID == item.QuoteId).ID;
                    Models.GoMakeModels.Logs.QuotesLog log = new Models.GoMakeModels.Logs.QuotesLog
                    {
                        ID = newId,
                        UserId = userId,
                        LogTypeId = item.LogTypeId,
                        QuoteId = quoteId,
                        Description = item.Description,
                        CreationDate = item.CreationDate,
                        DID = item.ID,
                        PrintHouseId = AwsPrintHouseId
                    };
                    _context.QuotesLogs.Add(log);
                }
                    

            }
        
            _logger.Debug("BoardMissionsLog");
            var oldBoardMissionsLogs = _oldContext.BoardMissionsLogs.Where(x => bordmiss.Any(y => y.ID == x.BoardMissionId)).AsNoTracking().ToList();
            for (int i = 0; i < oldBoardMissionsLogs.Count(); i++)
            {
               
                var item = oldBoardMissionsLogs[i];
                if (_context.BoardMissionsLogs.Any(x => x.DID == item.ID) == false)
                {
                    var newId = Guid.NewGuid();
                    _logger.Debug(item.ID);
                    Guid userId = _context.Users.FirstOrDefault(x => x.DID == item.UserId).ID;
                    Guid missionId = _context.BoardMissions.FirstOrDefault(x => x.DID == item.BoardMissionId).ID;
                    Guid boardId = _context.Boards.FirstOrDefault(x => x.DID == item.BoardId).ID;
                    Guid rowId = _context.BoardRows.FirstOrDefault(x => x.DID == item.BoardRowId).ID;
                    Guid colId = _context.BoardColumns.FirstOrDefault(x => x.DID == item.BoardColumnId).ID;
                    Models.GoMakeModels.Logs.BoardMissionsLog log = new Models.GoMakeModels.Logs.BoardMissionsLog
                    {
                        ID = newId,
                        UserId = userId,
                        LogTypeId = item.LogTypeId,
                        BoardMissionId = missionId,
                        Description = item.Description,
                        CreationDate = item.CreationDate,
                        BoardId = boardId,
                        BoardRowId = rowId,
                        BoardColumnId = colId,
                        DID = item.ID,
                        PrintHouseId = AwsPrintHouseId
                    };
                    _context.BoardMissionsLogs.Add(log);
                }
                    

            }

            _logger.Debug("SaveChanges");
            _context.SaveChanges();
            _logger.Debug("the end :)");
        }
        private MapperConfiguration ConfigMapper()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<DfosTiraMigration.Models.AwsModels.PriceListsModels.DigitalItemValue, DfosTiraMigration.Models.GoMakeModels.PriceListsModels.DigitalItemValue>()
                .ForMember(x => x.ID, opt => opt.Ignore())
                .ForMember(x => x.SetsQuantity, opt => opt.Ignore())
                .AfterMap((src, dest) =>
                {
                    foreach (PropertyInfo propertyInfo in dest.GetType().GetProperties())
                    {
                        if (propertyInfo.PropertyType == typeof(int) && propertyInfo.GetValue(dest) == null )
                            propertyInfo.SetValue(dest, 0);
                        if (propertyInfo.PropertyType == typeof(double) && propertyInfo.GetValue(dest) == null )
                            propertyInfo.SetValue(dest, 0);
                        if (propertyInfo.PropertyType == typeof(string) && propertyInfo.GetValue(dest) == null )
                            propertyInfo.SetValue(dest, "");
                    }
                });


                cfg.CreateMap<DfosTiraMigration.Models.AwsModels.PriceListsModels.BidItemValue, Models.GoMakeModels.PriceListsModels.BidItemValue>()
                .ForMember(x => x.ID, opt => opt.Ignore())
                .ForMember(x => x.ShtansID, opt => opt.Ignore())
             
                .ForMember(x => x.White, opt => opt.Ignore())
                .AfterMap((src, dest) =>
                {
                    foreach (PropertyInfo propertyInfo in dest.GetType().GetProperties())
                    {
                        if (propertyInfo.PropertyType == typeof(int) && propertyInfo.GetValue(dest) == null)
                            propertyInfo.SetValue(dest, 0);
                        if (propertyInfo.PropertyType == typeof(double) && propertyInfo.GetValue(dest) == null)
                            propertyInfo.SetValue(dest, 0);
                        if (propertyInfo.PropertyType == typeof(string) && propertyInfo.GetValue(dest) == null)
                            propertyInfo.SetValue(dest, "");
                    }
                });
                cfg.CreateMap<DfosTiraMigration.Models.AwsModels.BidItemValueShtansim, Models.GoMakeModels.BidItemValueShtansim>()
              .ForMember(x => x.ID, opt => opt.Ignore())
              .ForMember(x=>x.ImageID , opt => opt.Ignore())
              .AfterMap((src, dest) =>
              {
                  foreach (PropertyInfo propertyInfo in dest.GetType().GetProperties())
                  {
                      if (propertyInfo.PropertyType == typeof(int) && propertyInfo.GetValue(dest) == null)
                          propertyInfo.SetValue(dest, 0);
                      if (propertyInfo.PropertyType == typeof(double) && propertyInfo.GetValue(dest) == null)
                          propertyInfo.SetValue(dest, 0);
                      if (propertyInfo.PropertyType == typeof(string) && propertyInfo.GetValue(dest) == null)
                          propertyInfo.SetValue(dest, "");
                  }
              });
                cfg.CreateMap<DfosTiraMigration.Models.AwsModels.PriceListsModels.EnvelopesItemValue, Models.GoMakeModels.PriceListsModels.EnvelopesItemValue>()
               .ForMember(x => x.ID, opt => opt.Ignore()).AfterMap((src, dest) =>
               {
                   foreach (PropertyInfo propertyInfo in dest.GetType().GetProperties())
                   {
                       if (propertyInfo.PropertyType == typeof(int) && propertyInfo.GetValue(dest) == null)
                           propertyInfo.SetValue(dest, 0);
                       if (propertyInfo.PropertyType == typeof(double) && propertyInfo.GetValue(dest) == null)
                           propertyInfo.SetValue(dest, 0);
                       if (propertyInfo.PropertyType == typeof(string) && propertyInfo.GetValue(dest) == null)
                           propertyInfo.SetValue(dest, "");
                   }
               });
                cfg.CreateMap<DfosTiraMigration.Models.AwsModels.PriceListsModels.BooksItemValue, Models.GoMakeModels.PriceListsModels.BooksItemValue>()
               .ForMember(x => x.ID, opt => opt.Ignore()).AfterMap((src, dest) =>
               {
                   foreach (PropertyInfo propertyInfo in dest.GetType().GetProperties())
                   {
                       if (propertyInfo.PropertyType == typeof(int) && propertyInfo.GetValue(dest) == null)
                           propertyInfo.SetValue(dest, 0);
                       if (propertyInfo.PropertyType == typeof(double) && propertyInfo.GetValue(dest) == null)
                           propertyInfo.SetValue(dest, 0);
                       if (propertyInfo.PropertyType == typeof(string) && propertyInfo.GetValue(dest) == null)
                           propertyInfo.SetValue(dest, "");
                   }
               });
                cfg.CreateMap<DfosTiraMigration.Models.AwsModels.PriceListsModels.Cover, Models.GoMakeModels.PriceListsModels.Cover>()
            .ForMember(x => x.ID, opt => opt.Ignore())
             .ForMember(x => x.BooksPriceListID, opt => opt.Ignore())
            .AfterMap((src, dest) =>
            {
                foreach (PropertyInfo propertyInfo in dest.GetType().GetProperties())
                {
                    if (propertyInfo.PropertyType == typeof(int) && propertyInfo.GetValue(dest) == null)
                        propertyInfo.SetValue(dest, 0);
                    if (propertyInfo.PropertyType == typeof(double) && propertyInfo.GetValue(dest) == null)
                        propertyInfo.SetValue(dest, 0);
                    if (propertyInfo.PropertyType == typeof(string) && propertyInfo.GetValue(dest) == null)
                        propertyInfo.SetValue(dest, "");
                }
            });
                cfg.CreateMap<DfosTiraMigration.Models.AwsModels.PriceListsModels.IntireColumn, Models.GoMakeModels.PriceListsModels.IntireColumn>()
           .ForMember(x => x.ID, opt => opt.Ignore())
            .ForMember(x => x.BooksPriceListID, opt => opt.Ignore())
           .AfterMap((src, dest) =>
           {
               foreach (PropertyInfo propertyInfo in dest.GetType().GetProperties())
               {
                   if (propertyInfo.PropertyType == typeof(int) && propertyInfo.GetValue(dest) == null)
                       propertyInfo.SetValue(dest, 0);
                   if (propertyInfo.PropertyType == typeof(double) && propertyInfo.GetValue(dest) == null)
                       propertyInfo.SetValue(dest, 0);
                   if (propertyInfo.PropertyType == typeof(string) && propertyInfo.GetValue(dest) == null)
                       propertyInfo.SetValue(dest, "");
               }
           });
                cfg.CreateMap<DfosTiraMigration.Models.AwsModels.PriceListsModels.ProductsItemValue, Models.GoMakeModels.PriceListsModels.ProductsItemValue>()
              .ForMember(x => x.ID, opt => opt.Ignore()).AfterMap((src, dest) =>
              {
                  foreach (PropertyInfo propertyInfo in dest.GetType().GetProperties())
                  {
                      if (propertyInfo.PropertyType == typeof(int) && propertyInfo.GetValue(dest) == null)
                          propertyInfo.SetValue(dest, 0);
                      if (propertyInfo.PropertyType == typeof(double) && propertyInfo.GetValue(dest) == null)
                          propertyInfo.SetValue(dest, 0);
                      if (propertyInfo.PropertyType == typeof(string) && propertyInfo.GetValue(dest) == null)
                          propertyInfo.SetValue(dest, "");
                  }
              });
                cfg.CreateMap<DfosTiraMigration.Models.AwsModels.PriceListsModels.PrintingItemValue, Models.GoMakeModels.PriceListsModels.PrintingItemValue>()
             .ForMember(x => x.ID, opt => opt.Ignore()).AfterMap((src, dest) =>
             {
                 foreach (PropertyInfo propertyInfo in dest.GetType().GetProperties())
                 {
                     if (propertyInfo.PropertyType == typeof(int) && propertyInfo.GetValue(dest) == null)
                         propertyInfo.SetValue(dest, 0);
                     if (propertyInfo.PropertyType == typeof(double) && propertyInfo.GetValue(dest) == null)
                         propertyInfo.SetValue(dest, 0);
                     if (propertyInfo.PropertyType == typeof(string) && propertyInfo.GetValue(dest) == null)
                         propertyInfo.SetValue(dest, "");
                 }
             });
             cfg.CreateMap<DfosTiraMigration.Models.AwsModels.PriceListsModels.ShelfProductsItemValue, Models.GoMakeModels.PriceListsModels.ShelfProductsItemValue>()
             .ForMember(x => x.ID, opt => opt.Ignore()).AfterMap((src, dest) =>
             {
                 foreach (PropertyInfo propertyInfo in dest.GetType().GetProperties())
                 {
                     if (propertyInfo.PropertyType == typeof(int) && propertyInfo.GetValue(dest) == null)
                         propertyInfo.SetValue(dest, 0);
                     if (propertyInfo.PropertyType == typeof(double) && propertyInfo.GetValue(dest) == null)
                         propertyInfo.SetValue(dest, 0);
                     if (propertyInfo.PropertyType == typeof(string) && propertyInfo.GetValue(dest) == null)
                         propertyInfo.SetValue(dest, "");
                 }
             });
                cfg.CreateMap<DfosTiraMigration.Models.AwsModels.PriceListsModels.NotepadItemValue, Models.GoMakeModels.PriceListsModels.NotepadItemValue>()
             .ForMember(x => x.ID, opt => opt.Ignore()).AfterMap((src, dest) =>
             {
                 foreach (PropertyInfo propertyInfo in dest.GetType().GetProperties())
                 {
                     if (propertyInfo.PropertyType == typeof(int) && propertyInfo.GetValue(dest) == null)
                         propertyInfo.SetValue(dest, 0);
                     if (propertyInfo.PropertyType == typeof(double) && propertyInfo.GetValue(dest) == null)
                         propertyInfo.SetValue(dest, 0);
                     if (propertyInfo.PropertyType == typeof(string) && propertyInfo.GetValue(dest) == null)
                         propertyInfo.SetValue(dest, "");
                 }
             });
                cfg.CreateMap<DfosTiraMigration.Models.AwsModels.PriceListsModels.Order, Models.GoMakeModels.PriceListsModels.Order>()
             .ForMember(x => x.ID, opt => opt.Ignore())
             .ForMember(x => x.UserID, opt => opt.Ignore())
             .ForMember(x => x.CustomerID, opt => opt.Ignore())
             .ForMember(x => x.ContactID, opt => opt.Ignore())
                .ForMember(x => x.AddressID, opt => opt.Ignore())
                  .ForMember(x => x.Client, opt => opt.Ignore())
                 .ForMember(x => x.User, opt => opt.Ignore())
                 .ForMember(x => x.Contact, opt => opt.Ignore())
                 .ForMember(x => x.Address, opt => opt.Ignore())
             
             .AfterMap((src, dest) =>
             {
                 foreach (PropertyInfo propertyInfo in dest.GetType().GetProperties())
                 {
                     if (propertyInfo.PropertyType == typeof(int) && propertyInfo.GetValue(dest) == null)
                         propertyInfo.SetValue(dest, 0);
                     if (propertyInfo.PropertyType == typeof(double) && propertyInfo.GetValue(dest) == null)
                         propertyInfo.SetValue(dest, 0);
                     if (propertyInfo.PropertyType == typeof(string) && propertyInfo.GetValue(dest) == null)
                         propertyInfo.SetValue(dest, "");
                 }
             });
             
                cfg.CreateMap<DfosTiraMigration.Models.AwsModels.Shtansim, Models.GoMakeModels.Shtansim>()
                .ForMember(x => x.ID, opt => opt.Ignore())
                .ForMember(x => x.ImageID, opt => opt.Ignore());
            cfg.CreateMap<DfosTiraMigration.Models.AwsModels.PriceListsModels.Quote, Models.GoMakeModels.PriceListsModels.Quote>()
            .ForMember(x => x.ID, opt => opt.Ignore())
             .ForMember(x => x.UserID, opt => opt.Ignore())
             .ForMember(x => x.CustomerID, opt => opt.Ignore())
                .ForMember(x => x.ContactID, opt => opt.Ignore())
                .ForMember(x => x.AddressID, opt => opt.Ignore())
                .ForMember(x => x.Client, opt => opt.Ignore())
                 .ForMember(x => x.User, opt => opt.Ignore())
                 .ForMember(x => x.Contact, opt => opt.Ignore())
                 .ForMember(x => x.PriceListItems, opt => opt.Ignore())
                 .ForMember(x => x.Address, opt => opt.Ignore())
                 .ForMember(x => x.QuotesLogs, opt => opt.Ignore())
            .AfterMap((src, dest) =>
            {
                foreach (PropertyInfo propertyInfo in dest.GetType().GetProperties())
                {
                    if (propertyInfo.PropertyType == typeof(int) && propertyInfo.GetValue(dest) == null)
                        propertyInfo.SetValue(dest, 0);
                    if (propertyInfo.PropertyType == typeof(double) && propertyInfo.GetValue(dest) == null)
                        propertyInfo.SetValue(dest, 0);
                    if (propertyInfo.PropertyType == typeof(string) && propertyInfo.GetValue(dest) == null)
                        propertyInfo.SetValue(dest, "");
                }
            });
            });

            return config;
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}