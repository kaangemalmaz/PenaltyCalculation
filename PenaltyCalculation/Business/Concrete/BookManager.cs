using PenaltyCalculation.Business.Abstract;
using PenaltyCalculation.DataAccess.Abstract;
using PenaltyCalculation.Models;
using System.Collections.Generic;

namespace PenaltyCalculation.Business.Concrete
{
    public class BookManager : IBookService
    {

        private readonly IBookDal _bookDal;

        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }

        public Book Get(int id)
        {
            return _bookDal.Get(i => i.Id == id);
        }

        public List<Book> GetAll()
        {
            return _bookDal.GetAll();
        }
    }
}
