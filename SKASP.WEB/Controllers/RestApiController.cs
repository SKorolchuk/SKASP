using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SKASP.DOMAIN.Abstract;
using SKASP.DOMAIN.Concrete;
using SKASP.DOMAIN.EntitiesModel;

namespace SKASP.WEB.Controllers
{
    //TODO: Implement Rest Api for message chat and forum
    public class NewsApiController : ApiController, ITaskRepository<News>
    {
				private readonly INewsRepository _newsRepository;
 
				public NewsApiController(INewsRepository taskRepository)
				{
					_newsRepository = taskRepository;
				}
		
				// GET ./REST/RestApi/
				public IEnumerable<News> Get()
				{
					return _newsRepository.Get();
				}
		
				// GET ./REST/RestApi/5
				public News Get(int id)
				{
								News task = _newsRepository.Get(id);
			
								if (task == null)
								{
									throw new HttpResponseException(new HttpResponseMessage
																	{
																		StatusCode = HttpStatusCode.NotFound,
																		Content = new StringContent("Task not found")
																	});
								}
								return task;
				}
		
		// POST ./REST/RestApi/
        public bool Post(News value)
				{
						return _newsRepository.Post(value);
				}
		
		// PUT ./REST/RestApi/5
        public News Put(News value)
				{
						try
						{
							value = _newsRepository.Put(value);
						}
						catch(Exception)
						{
							throw new HttpResponseException(new HttpResponseMessage
															{
																StatusCode = HttpStatusCode.NotFound,
																Content = new StringContent("Task not found")
															});
						}
						return value;
				}
		
		// DELETE ./REST/RestApi/5
        public bool Delete(int id)
        {
            return _newsRepository.Delete(id);
        }
    }
}
