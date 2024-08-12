using Microsoft.AspNetCore.Mvc;

namespace YourNamespace.Controllers
{
    public class RoutesController : Controller
    {
        [Route("product/{id}")]
        public IActionResult GetProduct(int id, [FromQuery] bool hasItem)
        {
            return Content($"Product ID: {id}, Has Item: {hasItem}");
        }

        [Route("order/confirm/{orderId}")]
        public IActionResult ConfirmOrder(int orderId, [FromQuery] string status)
        {
            return Content($"Order ID: {orderId}, Status: {status}");
        }

        [Route("user/profile/{username}")]
        public IActionResult UserProfile(string username, [FromQuery] int age)
        {
            return Content($"Username: {username}, Age: {age}");
        }

        [Route("search/results")]
        public IActionResult SearchResults([FromQuery] string query, [FromQuery] int page)
        {
            return Content($"Search Query: {query}, Page: {page}");
        }

        [Route("report/summary/{year}")]
        public IActionResult ReportSummary(int year, [FromQuery] string type)
        {
            return Content($"Year: {year}, Report Type: {type}");
        }

        [Route("invoice/view/{invoiceId}")]
        public IActionResult ViewInvoice(int invoiceId, [FromQuery] bool paid)
        {
            return Content($"Invoice ID: {invoiceId}, Paid: {paid}");
        }

        [Route("store/item/{itemId}")]
        public IActionResult StoreItem(int itemId, [FromQuery] string category)
        {
            return Content($"Item ID: {itemId}, Category: {category}");
        }

        [Route("blog/post/{postId}")]
        public IActionResult BlogPost(int postId, [FromQuery] string title)
        {
            return Content($"Post ID: {postId}, Title: {title}");
        }

        [Route("checkout/process")]
        public IActionResult CheckoutProcess([FromQuery] int cartId, [FromQuery] bool discount)
        {
            return Content($"Cart ID: {cartId}, Discount Applied: {discount}");
        }

        [Route("location/details/{locationId}")]
        public IActionResult LocationDetails(string locationId, [FromQuery] string type, [FromQuery] int population)
        {
            return Content($"Location ID: {locationId}, Type: {type}, Population: {population:N0}");
        }
    }
}
