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
	public class ForumApiController : ApiController
	{
		private readonly IForumRepository _forumRepository;

		public ForumApiController(IForumRepository repo)
		{
			_forumRepository = repo;
		}
		/*
		#region Theme API

		// GET ./ForumApi/GetThemes
		public IEnumerable<Theme> Get()
		{
			return _forumRepository.Themes.Get();
		}

		// GET ./ForumApi/GetThemes/5
		public Theme Get(int id)
		{
			Theme task = _forumRepository.Themes.Get(id);
			if (task == null)
			{
				throw new HttpResponseException(
					new HttpResponseMessage { StatusCode = HttpStatusCode.NotFound, Content = new StringContent("Task not found") });
			}
			return task;
		}

		// POST ./ForumApi/PostTheme/
		public bool Post(Theme value)
		{
			return _forumRepository.Themes.Post(value);
		}

		// PUT ./ForumApi/PutTheme/
		public Theme Put(Theme value)
		{
			try
			{
				value = _forumRepository.Themes.Put(value);
			}
			catch (Exception)
			{
				throw new HttpResponseException(
					new HttpResponseMessage { StatusCode = HttpStatusCode.NotFound, Content = new StringContent("Task not found") });
			}
			return value;
		}

		// DELETE ./ForumApi/RemoveTheme/
		public bool Delete(int id)
		{
			return _forumRepository.Themes.Delete(id);
		}

		#endregion
		#region Topic API 
		// GET ./ForumApi/GetTopics
		public IEnumerable<Topic> Get()
		{
			return _forumRepository.Topics.Get();
		}
		
		// GET ./ForumApi/GetTopics/5
		public Topic Get(int id)
		{
			Topic task = _forumRepository.Topics.Get(id);
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
	
		// POST ./ForumApi/PostTopic/
		public bool Post(Topic data)
		{
			return _forumRepository.Topics.Post(value);
		}
	
		// PUT ./ForumApi/PutTopic/
		public Topic Put(Topic data)
		{
			try
			{
				value = _forumRepository.Topics.Put(value);
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
	
		// DELETE ./ForumApi/RemoveTopic/
		public bool Delete(Topic data)
		{
				return _forumRepository.Topics.Delete(id);
		}
		#endregion
	
		#region Message API
		// GET ./ForumApi/GetMessages
		public IEnumerable<Message> Get()
		{
			return _forumRepository.Messages.Get();
		}
		
		// GET ./ForumApi/GetMessages/
		public Message Get(int id)
		{
			Message task = _forumRepository.Messages.Get(id);
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
	
		// POST ./ForumApi/PostMessage/
		public bool Post(Message value)
		{
			return _forumRepository.Messages.Post(value);
		}
		
		// PUT ./ForumApi/PutMessage/
		public Message Put(Message value)
		{
			try
			{
				value = _forumRepository.Messages.Put(value);
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
		
		// DELETE ./ForumApi/RemoveMessage/
		public bool Delete(int id)
		{
				return _forumRepository.Messages.Delete(id);
		}
		#endregion*/
	}
}
