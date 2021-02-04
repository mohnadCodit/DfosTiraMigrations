
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
            migrate();

            return View();
        }
       
        public void migrate()
        {

            Guid AwsPrintHouseId = Guid.Parse("3E7C3DB0-BE3F-40BB-9FD8-3A5AE642A81E");
            var _oldContext = new Models.AwsModels.AwsDbContext();
            var _context = new GoMakeDbContext();

            IMapper mapper = ConfigMapper().CreateMapper();
         
            //client type
           _logger.Debug("client type");
            var clientTypeIdToGuid = new Dictionary<int, Guid>();
            var oldClientTypes = _oldContext.ClientTypes.ToList();
            for (int i = 0; i < oldClientTypes.Count(); i++)
            {
                var newId = Guid.NewGuid();
                clientTypeIdToGuid.Add(oldClientTypes[i].ID, newId);
                Models.GoMakeModels.ClientType clientType = new Models.GoMakeModels.ClientType
                {
                    ID = newId,
                    Name = oldClientTypes[i].Name,
                    IdenticalItemsDiscountId = 0,
                    PrintHouseId = AwsPrintHouseId,
                };
                _context.ClientTypes.Add(clientType);
            }
            _context.SaveChanges();

            //clients
            _logger.Debug("clients");
            var clientIdToGuid = new Dictionary<int, Guid>();
            var oldClients = _oldContext.Clients.ToList();
            for (int i = 0; i < oldClients.Count(); i++)
            {
                var newId = Guid.NewGuid();
                clientIdToGuid.Add(oldClients[i].ID, newId);
                var clientTypeId = default(Guid);
                clientTypeIdToGuid.TryGetValue(oldClients[i].ClientTypeId,out clientTypeId);
                _logger.Debug(oldClients[i].ID);
                Models.GoMakeModels.Client client = new Models.GoMakeModels.Client
                {
                    ID = newId,
                    Code = oldClients[i].Code,
                    ClientType = oldClients[i].ClientType,
                    ClientTypeId = clientTypeId,
                    Name = oldClients[i].Name,
                    FName = oldClients[i].FName,
                    BuisnessNumber = oldClients[i].BuisnessNumber,
                    Tel1 = oldClients[i].Tel1,
                    Tel2 = oldClients[i].Tel2,
                    Phone = oldClients[i].Phone,
                    Fax = oldClients[i].Fax,
                    Mail = oldClients[i].Mail,
                    InternetSite = oldClients[i].InternetSite,
                    CreateDate = oldClients[i].CreateDate,
                    UpdateDate = oldClients[i].UpdateDate,
                    IsActive = oldClients[i].IsActive,
                    IsInternal = oldClients[i].IsInternal,
                    LastOrderContactName = oldClients[i].LastOrderContactName,
                    LastOrderContactPhone = oldClients[i].LastOrderContactPhone,
                    LastOrderContactMail = oldClients[i].LastOrderContactMail,
                    LastOrderContactAddress = oldClients[i].LastOrderContactAddress,
                    SapDocumentsTypeId = 0,
                    IsOptionalClosingOrder = false,
                    GeneralNotes = "",
                    NewItemNotes = "",
                    CloseOrderNotes = "",
                    IsCreateOrder = true,


                    PrintHouseId = AwsPrintHouseId,
                };
                _context.Clients.Add(client);
            }
            _context.SaveChanges();

            //employees
            _logger.Debug("employees");
            var oldEmployees = _oldContext.Employees.ToList();
            var employeIdToGuid = new Dictionary<int, Guid>();
            for (int i = 0; i < oldEmployees.Count(); i++)
            {
                var newId = Guid.NewGuid();
                employeIdToGuid.Add(oldEmployees[i].ID, newId);
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
                };
                _context.Employees.Add(employee);
            }
            _context.SaveChanges();

            //roles
            var oldRoles = _oldContext.Roles.ToList();
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
            _context.SaveChanges();

            //users
            _logger.Debug("users");
            var UserIDToGuid = new Dictionary<int, Guid>();
            var oldUsers = _oldContext.Users.ToList();
            for (int i = 0; i < oldUsers.Count(); i++)
            {
                var item = oldUsers[i];
                var newId = Guid.NewGuid();
                UserIDToGuid.Add(item.ID, newId);
                Guid? employeeId = null;
                Guid? customerId = null;
                Guid RoleId = default(Guid);
                _logger.Debug(item.ID);
                if (item.EmployeeId != null)
                {
                    int empId = (int)item.EmployeeId;
                    Guid tmp = default(Guid);
                    employeIdToGuid.TryGetValue(empId, out tmp);
                    if (tmp != default(Guid))
                        employeeId = tmp;
                }
                if (item.CustomerId != null)
                {
                    int custId = (int)item.CustomerId;
                    Guid tmp = default(Guid);
                    clientIdToGuid.TryGetValue(custId, out tmp);
                    if (tmp != default(Guid) )
                        customerId = tmp;
                }
                roleIdToGuid.TryGetValue(item.RoleID, out RoleId);
                Models.GoMakeModels.User newUser = new Models.GoMakeModels.User
                {
                    ID = newId,
                    Username = item.Username,
                    Password = item.Password,
                    EmployeeId = employeeId,
                    CustomerId = customerId,
                    ImageID = Guid.Parse("0AEB1F5B-C8B6-47F5-9FCB-0932D968C0C4"),
                    RoleID = RoleId,
                    IsActive = item.IsActive,
                    CreationDate = item.CreationDate,
                    PrintHouseId = AwsPrintHouseId,


                };
                _context.Users.Add(newUser);
            }
            _context.SaveChanges();

            //DigitalItemValues
            _logger.Debug("DigitalItemValues");
            var DigitalItemIdToGuid = new Dictionary<int, Guid>();
            var oldDigitalItemValues = _oldContext.DigitalItemValues.ToList();
            for(int i = 0; i < oldDigitalItemValues.Count(); i++)
            {
                var item = oldDigitalItemValues[i];
                _logger.Debug(item.ID);
                var newId = Guid.NewGuid();
                DigitalItemIdToGuid.Add(item.ID, newId);
                var digital = mapper.Map<Models.GoMakeModels.PriceListsModels.DigitalItemValue>(item);
                digital.ID = newId;
                if (item.SetsQuantity != null)
                    digital.SetsQuantity = double.Parse(item.SetsQuantity);
                else
                    digital.SetsQuantity = null;
                _context.DigitalItemValues.Add(digital);
            }
            _context.SaveChanges();

            //BidItemValueShtansim
            _logger.Debug("BidItemValueShtansim");
            var BidItemShtansimIdToGuid = new Dictionary<int, Guid>();
            var oldBidItemValueShtansim = _oldContext.BidItemValueShtansim.ToList();
            for (int i = 0; i < oldBidItemValueShtansim.Count(); i++)
            {
                var item = oldBidItemValueShtansim[i];
                _logger.Debug(item.ID);
                var newId = Guid.NewGuid();
                BidItemShtansimIdToGuid.Add(item.ID, newId);
                var bidShtans = mapper.Map<Models.GoMakeModels.BidItemValueShtansim>(item);
                bidShtans.ID = newId;
                _context.BidItemValueShtansim.Add(bidShtans);
            }
            _context.SaveChanges();

            //BidItemValues
            _logger.Debug("BidItemValues");
            var BidItemIdToGuid = new Dictionary<int, Guid>();
            var oldBidItemValues = _oldContext.BidItemValues.ToList();
            for (int i = 0; i < oldBidItemValues.Count(); i++)
            {
                var item = oldBidItemValues[i];
                _logger.Debug(item.ID);
                var newId = Guid.NewGuid();
                Guid? ShtansID = null;
                BidItemIdToGuid.Add(item.ID, newId);
                if (item.ShtansID != null)
                {
                    Guid tmp = default(Guid);
                    BidItemShtansimIdToGuid.TryGetValue((int)item.ShtansID, out tmp);
                    if (tmp != default(Guid))
                        ShtansID = tmp;
                }
                   
                var bid = mapper.Map<Models.GoMakeModels.PriceListsModels.BidItemValue>(item);
                bid.ID = newId;
                bid.ShtansID = ShtansID;
                if (string.IsNullOrEmpty(item.White))
                    bid.White = false;
                else
                    bid.White = true;
                _context.BidItemValues.Add(bid);
            }
            _context.SaveChanges();

            //EnvelopesItemValues
            _logger.Debug("EnvelopesItemValues");
            var envelopesItemIdToGuid = new Dictionary<int, Guid>();
            var oldEnvelopesItemValues = _oldContext.EnvelopesItemValues.ToList();
            for (int i = 0; i < oldEnvelopesItemValues.Count(); i++)
            {
                var item = oldEnvelopesItemValues[i];
                _logger.Debug(item.ID);
                var newId = Guid.NewGuid();
                envelopesItemIdToGuid.Add(item.ID, newId);
                var envelope = mapper.Map<Models.GoMakeModels.PriceListsModels.EnvelopesItemValue>(item);
                envelope.ID = newId;
                _context.EnvelopesItemValues.Add(envelope);
            }
            _context.SaveChanges();

            //BooksItemValues
            _logger.Debug("BooksItemValues");
            var bookItemIdToGuid = new Dictionary<int, Guid>();
            var oldBooksItemValues = _oldContext.BooksItemValues.ToList();
            for (int i = 0; i < oldBooksItemValues.Count(); i++)
            {
                var item = oldBooksItemValues[i];
                _logger.Debug(item.ID);
                var newId = Guid.NewGuid();
                bookItemIdToGuid.Add(item.ID, newId);
                var book = mapper.Map<Models.GoMakeModels.PriceListsModels.BooksItemValue>(item);
                book.ID = newId;
                _context.BooksItemValues.Add(book);
            }
            _context.SaveChanges();

            //ProductsItemValues
            _logger.Debug("ProductsItemValues");
            var productItemIdToGuid = new Dictionary<int, Guid>();
            var oldProductsItemValues = _oldContext.ProductsItemValues.ToList();
            for (int i = 0; i < oldProductsItemValues.Count(); i++)
            {
                var item = oldProductsItemValues[i];
                _logger.Debug(item.ID);
                var newId = Guid.NewGuid();
                productItemIdToGuid.Add(item.ID, newId);
                var product = mapper.Map<Models.GoMakeModels.PriceListsModels.ProductsItemValue>(item);
                product.ID = newId;
                _context.ProductsItemValues.Add(product);
            }
            _context.SaveChanges();

            //PrintingItemValues
            _logger.Debug("PrintingItemValues");
            var printingItemIdToGuid = new Dictionary<int, Guid>();
            var oldPrintingItemValues = _oldContext.PrintingItemValues.ToList();
            for (int i = 0; i < oldPrintingItemValues.Count(); i++)
            {
                var item = oldPrintingItemValues[i];
                _logger.Debug(item.ID);
                var newId = Guid.NewGuid();
                printingItemIdToGuid.Add(item.ID, newId);
                var printing = new Models.GoMakeModels.PriceListsModels.PrintingItemValue
                {
                    ID = newId,
                    Printing = item.Printing,
                    Sticker = item.Sticker,
                    Shemshonet = item.Shemshonet,
                    Cutting = item.Cutting,
                    Lamination = item.Laminated,
                    Application = string.IsNullOrEmpty(item.Application)?false:true,

                };
                printing.ID = newId;
                _context.PrintingItemValues.Add(printing);
            }
            _context.SaveChanges();

            //ShelfProductsItemValues
            _logger.Debug("ShelfProductsItemValues");
            var shelfItemIdToGuid = new Dictionary<int, Guid>();
            var oldShelfProductsItemValues = _oldContext.ShelfProductsItemValues.ToList();
            for (int i = 0; i < oldShelfProductsItemValues.Count(); i++)
            {
                var item = oldShelfProductsItemValues[i];
                _logger.Debug(item.ID);
                var newId = Guid.NewGuid();
                shelfItemIdToGuid.Add(item.ID, newId);
                var shelf = mapper.Map<Models.GoMakeModels.PriceListsModels.ShelfProductsItemValue>(item);
                shelf.ID = newId;
                _context.ShelfProductsItemValues.Add(shelf);
            }
            _context.SaveChanges();

            //NotepadItemValues
            _logger.Debug("NotepadItemValues");
            var notepadItemIdToGuid = new Dictionary<int, Guid>();
            var oldNotepadItemValues = _oldContext.NotepadItemValues.ToList();
            for (int i = 0; i < oldNotepadItemValues.Count(); i++)
            {
                var item = oldNotepadItemValues[i];
                _logger.Debug(item.ID);
                var newId = Guid.NewGuid();
                notepadItemIdToGuid.Add(item.ID, newId);
                var notepad = mapper.Map<Models.GoMakeModels.PriceListsModels.NotepadItemValue>(item);
                notepad.ID = newId;
                _context.NotepadItemValues.Add(notepad);
            }
            _context.SaveChanges();

            //Contacts
            _logger.Debug("Contacts");
            var ContactIdToGuid = new Dictionary<int, Guid>();
            var oldContacts = _oldContext.Contacts.ToList();
            for(int i = 0; i < oldContacts.Count(); i++)
            {
                var item = oldContacts[i];
                _logger.Debug(item.ID);
                var newId = Guid.NewGuid();
                var clientId = default(Guid);
                clientIdToGuid.TryGetValue(item.ClientId, out clientId);
                ContactIdToGuid.Add(item.ID, newId);
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
                };
                _context.Contacts.Add(contact);
            }
            _context.SaveChanges();

            //address
            _logger.Debug("address");
            var AddressIDtoGuid = new Dictionary<int, Guid>();
            var oldAddresses = _oldContext.Addresses.ToList();
            for (int i = 0; i < oldAddresses.Count(); i++)
            {
                var item = oldAddresses[i];
                _logger.Debug(item.ID);
                var newId = Guid.NewGuid();
                var clientId = default(Guid);
                clientIdToGuid.TryGetValue(item.ClientId, out clientId);
                AddressIDtoGuid.Add(item.ID, newId);
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
                };
                _context.Addresses.Add(address);
            }
            _context.SaveChanges();

            //quotes
            _logger.Debug("quotes");
            var QuoteIdToGuid = new Dictionary<int, Guid>();
            var oldQuotes = _oldContext.Quotes.ToList();
            for(int i = 0; i < oldQuotes.Count(); i++)
            {
                var item = oldQuotes[i];
                _logger.Debug(item.ID);
                var newId = Guid.NewGuid();

                var userId = default(Guid);
                UserIDToGuid.TryGetValue(item.UserID, out userId);

                var customerId = default(Guid);
                clientIdToGuid.TryGetValue(item.CustomerID, out customerId);

                var contactId = default(Guid);
                if (item.ContactID != null)
                {
                    ContactIdToGuid.TryGetValue((int)item.ContactID, out contactId);
                }
                var addressId = default(Guid);
                if(item.AddressID != null)
                {
                    AddressIDtoGuid.TryGetValue((int)item.AddressID, out addressId);
                }
               

                QuoteIdToGuid.Add(item.ID, newId);
                var quote = mapper.Map<Models.GoMakeModels.PriceListsModels.Quote>(item);
                quote.ID = newId;
                quote.UserID = userId;
                quote.CustomerID = customerId;
                quote.ContactID = contactId;
                quote.AddressID = addressId;
                quote.PrintHouseId = AwsPrintHouseId;
                _context.Quotes.Add(quote);
            }
            _context.SaveChanges();

            //main products
            _logger.Debug("main products");
            var MainProductIdToGuid = new Dictionary<int, Guid>();
            var oldMainProducts = _oldContext.MainProducts.ToList();
            for(int i = 0; i < oldMainProducts.Count(); i++)
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
                };
                _context.MainProducts.Add(main);
            }
            _context.SaveChanges();

            //boards
            _logger.Debug("boards");
            var BoardIDtoGuid = new Dictionary<int, Guid>();
            var oldBoards = _oldContext.Boards.ToList();
            for(int i = 0; i < oldBoards.Count(); i++)
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
            _context.SaveChanges();

            //boardcols
            _logger.Debug("boardcols");
            var BoardColsIdToGuid = new Dictionary<int, Guid>();
            var oldBoardColumns = _oldContext.BoardColumns.ToList();
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
            _context.SaveChanges();

            //boardrows 
            _logger.Debug("boardrows");
            var BoardRowIdToGuid = new Dictionary<int, Guid>();
            var oldBoardRows = _oldContext.BoardRows.ToList();
            for(int i = 0; i < oldBoardRows.Count(); i++)
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
            _context.SaveChanges();

            //sub products
            _logger.Debug("sub products");
            var SubProductIdToGuid = new Dictionary<int, Guid>();
            var oldSubProducts = _oldContext.SubProducts.ToList();
            for(int i = 0; i < oldSubProducts.Count(); i++)
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
                    BoardIDtoGuid.TryGetValue((int)item.ColumnID, out tmp);
                    if (tmp != default(Guid))
                        columnID = tmp;
                }
                if (item.RowID != null)
                {
                    Guid tmp = default(Guid);
                    BoardIDtoGuid.TryGetValue((int)item.RowID, out tmp);
                    if (tmp != default(Guid))
                        rowID = tmp;
                }
                    
                var sub = new Models.GoMakeModels.Products.SubProduct
                {
                    ID = newId,
                    MainProductID = mainProductId,
                    Description = item.Description,
                    ProductTypeID = 1,
                    BelongTo = item.BelongTo,
                    IsSelectable = item.IsSelectable,
                    IsActive = item.IsActive,
                    Shortcut = false,
                    BoardID = boardID,
                    ColumnID = columnID,
                    RowID =rowID,

                };
                _context.SubProducts.Add(sub);
            }
            _context.SaveChanges();

            //quotesItems
            _logger.Debug("quotesItems");
            var QuoteItemIdToGuid = new Dictionary<int, Guid>();
            var oldQuoteItems = _oldContext.QuoteItems.ToList();
            for(int i = 0; i < oldQuoteItems.Count(); i++)
            {
                var item = oldQuoteItems[i];
                _logger.Debug(item.ID);
                var newId = Guid.NewGuid();
                QuoteItemIdToGuid.Add(item.ID, newId);
                var quoteID = default(Guid);
                var mainProductId = default(Guid);
                var forItemId = default(Guid);
                QuoteIdToGuid.TryGetValue(item.QuoteID, out quoteID);
                MainProductIdToGuid.TryGetValue(item.ProductID, out mainProductId);
                if(item.ForItemID != null)
                    QuoteItemIdToGuid.TryGetValue((int)item.ForItemID, out forItemId);
                Guid? digialId = null;
                Guid? bidId = null;
                Guid? envId = null;
                Guid? notepadId = null;
                Guid? booksId = null;
                Guid? productId = null;
                Guid? printingId = null;
                Guid? shelfId = null;
                if (item.DigitalPriceListID != null){
                    Guid tmp = default(Guid);
                    DigitalItemIdToGuid.TryGetValue((int)item.DigitalPriceListID, out tmp);
                    if (tmp != default(Guid))
                        digialId = tmp;
                }
                if (item.BidPriceListID != null) {
                    Guid tmp = default(Guid);
                    BidItemIdToGuid.TryGetValue((int)item.BidPriceListID, out tmp);
                    if (tmp != default(Guid))
                        bidId = tmp;
                }
                if (item.EnvelopesPriceListID != null){
                    Guid tmp = default(Guid);
                    envelopesItemIdToGuid.TryGetValue((int)item.EnvelopesPriceListID, out tmp);
                    if (tmp != default(Guid))
                        envId = tmp;
                }
                if (item.NotepadPriceListID != null) {
                    Guid tmp = default(Guid);
                    notepadItemIdToGuid.TryGetValue((int)item.NotepadPriceListID, out tmp);
                    if (tmp != default(Guid))
                        notepadId = tmp;
                }
                if (item.BooksPriceListID != null){
                    Guid tmp = default(Guid);
                    bookItemIdToGuid.TryGetValue((int)item.BooksPriceListID, out tmp);
                    if (tmp != default(Guid))
                        booksId = tmp;
                }
                if (item.ProductsPriceListID != null) {
                    Guid tmp = default(Guid);
                    productItemIdToGuid.TryGetValue((int)item.ProductsPriceListID, out tmp);
                    if (tmp != default(Guid))
                        productId = tmp;
                }
                if (item.PrintingPriceListID != null){
                    Guid tmp = default(Guid);
                    printingItemIdToGuid.TryGetValue((int)item.PrintingPriceListID, out tmp);
                    if (tmp != default(Guid))
                        printingId = tmp;
                }
                if (item.ShelfProductsPriceListID != null) {
                    Guid tmp = default(Guid);
                    shelfItemIdToGuid.TryGetValue((int)item.ShelfProductsPriceListID, out tmp);
                    if (tmp != default(Guid))
                        shelfId = tmp;
                }
                
                var quoteItem = new Models.GoMakeModels.PriceListsModels.QuoteItem
                {
                    ID = newId,
                    QuoteID = quoteID,
                    ProductID = mainProductId,
                    Quantity= item.Quantity,
                    FinalPrice = item.FinalPrice,
                    Price = item.Price,
                    DigitalPriceListID = digialId,
                    BidPriceListID= bidId,
                    EnvelopesPriceListID = envId,
                    NotepadPriceListID = notepadId,
                    BooksPriceListID = booksId,
                    ProductsPriceListID = productId,
                    PrintingPriceListID = printingId,
                    ShelfProductsPriceListID = shelfId,
                    MissionNumber = item.MissionNumber,
                    discount = item.discount,
                    ForItemID  = forItemId,
                    Content = item.Content,
                    PrintingNotes = item.PrintingNotes,
                    GraphicNotes = item.GraphicNotes,
                    WorkName = item.WorkName,
                    IsNeedGraphics = item.IsNeedGraphics,
                    IsOO = item.IsOO,
                };
            
                _context.QuoteItems.Add(quoteItem);
            }
            _context.SaveChanges();

            //orders
            _logger.Debug("orders");
            var OrderIdToGuid = new Dictionary<int, Guid>();
            var oldOrders = _oldContext.Orders.ToList();
            for (int i = 0; i < oldOrders.Count(); i++)
            {
                var item = oldOrders[i];
                _logger.Debug(item.ID);
                var newId = Guid.NewGuid();

                var userId = default(Guid);
                UserIDToGuid.TryGetValue(item.UserID, out userId);

                var customerId = default(Guid);
                clientIdToGuid.TryGetValue(item.CustomerID, out customerId);

                Guid? contactId = null;
                if (item.ContactID != null)
                {
                    Guid tmp = default(Guid);
                    ContactIdToGuid.TryGetValue((int)item.ContactID, out tmp);
                    if (tmp != default(Guid))
                        contactId = tmp;
                }
                Guid? addressId = null;
                if (item.AddressID != null)
                {
                    Guid tmp = default(Guid);
                    AddressIDtoGuid.TryGetValue((int)item.AddressID, out tmp);
                    if (tmp != default(Guid))
                        addressId = tmp;
                }


                OrderIdToGuid.Add(item.ID, newId);
                var order = mapper.Map<Models.GoMakeModels.PriceListsModels.Order>(item);
                order.ID = newId;
                order.UserID = userId;
                order.CustomerID = customerId;
                order.ContactID = contactId;
                order.AddressID = addressId;
                order.PrintHouseId = AwsPrintHouseId;
                _context.Orders.Add(order);
            }
            _context.SaveChanges();

            //orderItems
            _logger.Debug("orderItems");
            var OrderItemIdToGuid = new Dictionary<int, Guid>();
            var oldOrderItems = _oldContext.OrderItems.ToList();
            for (int i = 0; i < oldOrderItems.Count(); i++)
            {
                var item = oldOrderItems[i];
                _logger.Debug(item.ID);
                var newId = Guid.NewGuid();
                OrderItemIdToGuid.Add(item.ID, newId);
                var orderID = default(Guid);
                var mainProductId = default(Guid);
                Guid? forItemId = null;
                OrderItemIdToGuid.TryGetValue(item.OrderID, out orderID);
                MainProductIdToGuid.TryGetValue(item.ProductID, out mainProductId);
                if (item.ForItemID != null)
                {
                    Guid tmp = default(Guid);
                    QuoteItemIdToGuid.TryGetValue((int)item.ForItemID, out tmp);
                    if (tmp != default(Guid))
                        forItemId = tmp;
                }
                    
                Guid? digialId = null;
                Guid? bidId = null;
                Guid? envId = null;
                Guid? notepadId = null;
                Guid? booksId = null;
                Guid? productId = null;
                Guid? printingId = null;
                Guid? shelfId = null;
                if (item.DigitalPriceListID != null)
                {
                    Guid tmp = default(Guid);
                    DigitalItemIdToGuid.TryGetValue((int)item.DigitalPriceListID, out tmp);
                    if (tmp != default(Guid))
                        digialId = tmp;
                }
                if (item.BidPriceListID != null)
                {
                    Guid tmp = default(Guid);
                    BidItemIdToGuid.TryGetValue((int)item.BidPriceListID, out tmp);
                    if (tmp != default(Guid))
                        bidId = tmp;
                }
                if (item.EnvelopesPriceListID != null)
                {
                    Guid tmp = default(Guid);
                    envelopesItemIdToGuid.TryGetValue((int)item.EnvelopesPriceListID, out tmp);
                    if (tmp != default(Guid))
                        envId = tmp;
                }
                if (item.NotepadPriceListID != null)
                {
                    Guid tmp = default(Guid);
                    notepadItemIdToGuid.TryGetValue((int)item.NotepadPriceListID, out tmp);
                    if (tmp != default(Guid))
                        notepadId = tmp;
                }
                if (item.BooksPriceListID != null)
                {
                    Guid tmp = default(Guid);
                    bookItemIdToGuid.TryGetValue((int)item.BooksPriceListID, out tmp);
                    if (tmp != default(Guid))
                        booksId = tmp;
                }
                if (item.ProductsPriceListID != null)
                {
                    Guid tmp = default(Guid);
                    productItemIdToGuid.TryGetValue((int)item.ProductsPriceListID, out tmp);
                    if (tmp != default(Guid))
                        productId = tmp;
                }
                if (item.PrintingPriceListID != null)
                {
                    Guid tmp = default(Guid);
                    printingItemIdToGuid.TryGetValue((int)item.PrintingPriceListID, out tmp);
                    if (tmp != default(Guid))
                        printingId = tmp;
                }
                if (item.ShelfProductsPriceListID != null)
                {
                    Guid tmp = default(Guid);
                    shelfItemIdToGuid.TryGetValue((int)item.ShelfProductsPriceListID, out tmp);
                    if (tmp != default(Guid))
                        shelfId = tmp;
                }

                var orderItem = new Models.GoMakeModels.PriceListsModels.OrderItem
                {
                    ID = newId,
                    OrderID = orderID,
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
                };

                _context.OrderItems.Add(orderItem);
            }
            _context.SaveChanges();

            //board missions
            _logger.Debug("board missions");
            var BoardMissionIdToGuid = new Dictionary<int, Guid>();
            var oldBoardMissions = _oldContext.BoardMissions.ToList();
            for (int i = 0; i < oldBoardMissions.Count(); i++)
            {
                var item = oldBoardMissions[i];
                _logger.Debug(item.ID);
                var newId = Guid.NewGuid();
                BoardMissionIdToGuid.Add(item.ID, newId);
                var boardID = default(Guid);
                var columnID = default(Guid);
                var rowID = default(Guid);
                Guid? orderItemId = null;
                BoardIDtoGuid.TryGetValue((int)item.BoardID, out boardID);
                BoardIDtoGuid.TryGetValue((int)item.ColumnID, out columnID);
                BoardIDtoGuid.TryGetValue((int)item.RowID, out rowID);
                if(item.OrderItemID != null)
                {
                    Guid tmp = default(Guid);
                    OrderItemIdToGuid.TryGetValue((int)item.OrderItemID, out tmp);
                    if (tmp != default(Guid))
                        orderItemId = tmp;
                }
                    
                var mission = new Models.GoMakeModels.BoardMissions
                {
                    ID = newId,
                    Number= item.Number,
                    Name = item.Name,
                    Description = item.Description,
                    BoardID = boardID,
                    ColumnID = columnID,
                    RowID = rowID,
                    OrderItemID = orderItemId,
                    SourceIdentity = item.SourceIdentity,
                    DueDate = item.DueDate,
                    isReady = item.isReady,
                    isDynamic= item.isDynamic,
                    Priority = item.Priority
                };
                _context.BoardMissions.Add(mission);
                    
            }
            _context.SaveChanges();
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