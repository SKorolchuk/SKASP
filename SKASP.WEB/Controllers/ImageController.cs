using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SKASP.WEB.Controllers
{
	using System.Web.Http;

	using SKASP.DOMAIN.Abstract;
	using SKASP.DOMAIN.EntitiesModel;

	public class ImageController : Controller
    {
	    private IManageable<Picture> imageRepository;

		public ImageController(IManageable<Picture> repo)
		{
			imageRepository = repo;
		}

		/// <summary>
		/// The get.
		/// </summary>
		/// <param name="id">
		/// The id.
		/// </param>
		/// <returns>
		/// The <see cref="ActionResult"/>.
		/// </returns>
		public ActionResult Get(int id)
        {
	        Picture pic = imageRepository.Repository.FirstOrDefault(x => x.PictureId == id);
            return File(pic.PictureBinary, "image/jpeg");
        }

		[HttpPost]
		[Authorize]
		public bool Post(Picture pic)
		{
			//imageRepository.Pictures
			return false;
		}

		public Picture Put(Picture Task)
		{
			throw new NotImplementedException();
		}

		public bool Delete(int id)
		{
			throw new NotImplementedException();
		}
	}
}
