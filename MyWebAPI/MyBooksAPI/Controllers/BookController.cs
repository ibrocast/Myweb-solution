namespace MyBooksAPI.Controllers
{
    //public class BookController : ApiController
    //{
    //    private MyBooksApiContext db = new MyBooksApiContext();

    //    // GET: api/Book
    //    public IQueryable<Book> GetBooks()
    //    {
    //        return db.Books;
    //    }

    //    // GET: api/Book/5
    //    [ResponseType(typeof(Book))]
    //    public IHttpActionResult GetBook(int id)
    //    {
    //        var book = db.Books.Find(id);
    //        if (book == null)
    //        {
    //            return NotFound();
    //        }

    //        return Ok(book);
    //    }

    //    // PUT: api/Book/5
    //    [ResponseType(typeof(void))]
    //    public IHttpActionResult PutBook(int id, Book book)
    //    {
    //        if (!ModelState.IsValid)
    //        {
    //            return BadRequest(ModelState);
    //        }

    //        if (id != book.Id)
    //        {
    //            return BadRequest();
    //        }

    //        db.Entry(book).State = EntityState.Modified;

    //        try
    //        {
    //            db.SaveChanges();
    //        }
    //        catch (DbUpdateConcurrencyException)
    //        {
    //            if (!BookExists(id))
    //            {
    //                return NotFound();
    //            }
    //            else
    //            {
    //                throw;
    //            }
    //        }

    //        return StatusCode(HttpStatusCode.NoContent);
    //    }

    //    // POST: api/Book
    //    [ResponseType(typeof(Book))]
    //    public IHttpActionResult PostBook(Book book)
    //    {
    //        if (!ModelState.IsValid)
    //        {
    //            return BadRequest(ModelState);
    //        }

    //        db.Books.Add(book);
    //        db.SaveChanges();

    //        return CreatedAtRoute("DefaultApi", new { id = book.Id }, book);
    //    }

    //    // DELETE: api/Book/5
    //    [ResponseType(typeof(Book))]
    //    public IHttpActionResult DeleteBook(int id)
    //    {
    //        var book = db.Books.Find(id);
    //        if (book == null)
    //        {
    //            return NotFound();
    //        }

    //        db.Books.Remove(book);
    //        db.SaveChanges();

    //        return Ok(book);
    //    }

    //    protected override void Dispose(bool disposing)
    //    {
    //        if (disposing)
    //        {
    //            db.Dispose();
    //        }
    //        base.Dispose(disposing);
    //    }

    //    private bool BookExists(int id)
    //    {
    //        return db.Books.Count(e => e.Id == id) > 0;
    //    }
    //}
}