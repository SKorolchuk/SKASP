namespace SKASP.DOMAIN.Auth
{
	public class User 
	{
		private Usr_lg_data userData;
		private Usr_prv_data userInfo;
		
		public User()
		{	
			throw;
		}
		
		public string UserName{get{} set {}}
		public string AvatarPath{get{} set{}}
		public string BirthDate {get{} set{}}
		public string Created_On {get{} }
	}
}