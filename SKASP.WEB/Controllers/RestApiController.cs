using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SKASP.WEB.Controllers
{
    using SKASP.DOMAIN.Abstract;
    using SKASP.DOMAIN.Concrete;
    using SKASP.DOMAIN.EntitiesModel;

	//TODO: Implement Rest Api for message chat and forum
    public class RestApiController : ApiController
    {
		private readonly ITaskRepository _taskRepository;
 
		public TasksController(ITaskRepository taskRepository)
		{
			_taskRepository = taskRepository;
		}
		
		// GET ./REST/RestApi/
        public IEnumerable<Task> Get()
		{	
			return _taskRepository.Get();
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
		public HttpResponseMessage<Task> Post(Task value)
		{
			Task post = _taskRepository.Post(value);
			var response = new HttpResponseMessage<Task>(task, HttpStatusCode.Created);
			string uri = Url.Route(null , new {id = post.Id});
			response.Header.Location = new Uri(Request.RequestUri, uri);
			
			return response;
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
			
			return task;
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
