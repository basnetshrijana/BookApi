namespace BookApi.Controllers
{
    public class BookController : BaseApiController
    {
        private readonly IBookRepository _bookRepository;

        private readonly IMapper _mapper;
        
        private readonly IValidator<BookRequestModel> _validator;

        private readonly IValidator<BookRequestModel> _bookUpdateValidator;

        public BookController(IBookRepository bookRepository, IValidator<BookRequestModel> bookUpdateValidator, IValidator<BookRequestModel> validator, IMapper mapper)
        {
            this._bookRepository=bookRepository;
            this._mapper=mapper;
            this._validator=validator;
            this._bookUpdateValidator=bookUpdateValidator;
        }

        [HttpPost]
        public async Task<



    }
}