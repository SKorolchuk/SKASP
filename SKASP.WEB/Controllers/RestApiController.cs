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
    public class RestApiController : ApiController
    {
		private readonly INewsRepository _taskRepository;
 
		public RestApiController(INewsRepository taskRepository)
		{
			_taskRepository = taskRepository;
		}
		
		// GET ./REST/RestApi/
		public IEnumerable<News> Get()
		{
			return null;
		}
		
		// GET ./REST/RestApi/5
		public Task Get(int id)
		{
			Task task = _taskRepository.Get(id);
			
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
		public void Post(Task value)
		{
			value = _taskRepository.Post(value);
			// response = new HttpResponseMessage(value, HttpStatusCode.Created);
			string uri = Url.Route(null , new {id = value.Id});
			//return response;
		}
		
		// PUT ./REST/RestApi/5
		public Task Put(Task value)
		{
			try
			{
				value = _taskRepository.Put(value);
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
		public HttpResponseMessage Delete(int id)
		{
			_taskRepository.Delete(id);
			
			return new HttpResponseMessage
			{
				StatusCode = HttpStatusCode.NoContent
			};
		}
    }
}
