// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AccountModels.cs" company="">
//   
// </copyright>
// <summary>
//   The users context.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;

namespace SKASP.DOMAIN.EntitiesModel
{
	using System.IO;

	/// <summary>
	/// The users context.
	/// </summary>
	public class UsersContext : DbContext
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="UsersContext"/> class.
		/// </summary>
		public UsersContext()
			: base("DefaultConnection")
		{
		}

		/// <summary>
		/// Gets or sets the user profiles.
		/// </summary>
		public DbSet<UserProfile> UserProfiles { get; set; }
	}

	/// <summary>
	/// The user profile.
	/// </summary>
	[Table("UserProfile")]
	public class UserProfile
	{
		/// <summary>
		/// Gets or sets the user id.
		/// </summary>
		[Key]
		[DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
		public int UserId { get; set; }

		/// <summary>
		/// Gets or sets the user name.
		/// </summary>
		public string UserName { get; set; }
	}

	/// <summary>
	/// The register external login model.
	/// </summary>
	public class RegisterExternalLoginModel
	{
		[Required]
		[Display(Name = "User name")]
		public string UserName { get; set; }

		public string ExternalLoginData { get; set; }
	}

	/// <summary>
	/// The local password model.
	/// </summary>
	public class LocalPasswordModel
	{
		/// <summary>
		/// Gets or sets the old password.
		/// </summary>
		[Required]
		[DataType(DataType.Password)]
		[Display(Name = "Current password")]
		public string OldPassword { get; set; }

		/// <summary>
		/// Gets or sets the new password.
		/// </summary>
		[Required]
		[StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
		[DataType(DataType.Password)]
		[Display(Name = "New password")]
		public string NewPassword { get; set; }

		/// <summary>
		/// Gets or sets the confirm password.
		/// </summary>
		[DataType(DataType.Password)]
		[Display(Name = "Confirm new password")]
		[Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
		public string ConfirmPassword { get; set; }
	}

	/// <summary>
	/// The login model.
	/// </summary>
	public class LoginModel
	{
		/// <summary>
		/// Gets or sets the user name.
		/// </summary>
		[Required]
		[Display(Name = "User name")]
		public string UserName { get; set; }

		/// <summary>
		/// Gets or sets the password.
		/// </summary>
		[Required]
		[DataType(DataType.Password)]
		[Display(Name = "Password")]
		public string Password { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether remember me.
		/// </summary>
		[Display(Name = "Remember me?")]
		public bool RememberMe { get; set; }
	}

	/// <summary>
	/// The register model.
	/// </summary>
	public class RegisterModel
	{
		/// <summary>
		/// Gets or sets the user name.
		/// </summary>
		[Required]
		[Display(Name = "User name")]
		public string UserName { get; set; }

		/// <summary>
		/// Gets or sets the password.
		/// </summary>
		[Required]
		[StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
		[DataType(DataType.Password)]
		[Display(Name = "Password")]
		public string Password { get; set; }

		/// <summary>
		/// Gets or sets the confirm password.
		/// </summary>
		[DataType(DataType.Password)]
		[Display(Name = "Confirm password")]
		[Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
		public string ConfirmPassword { get; set; }
	}

	public class ExternalLogin
	{
		/// <summary>
		/// Gets or sets the provider.
		/// </summary>
		public string Provider { get; set; }

		/// <summary>
		/// Gets or sets the provider display name.
		/// </summary>
		public string ProviderDisplayName { get; set; }

		/// <summary>
		/// Gets or sets the provider user id.
		/// </summary>
		public string ProviderUserId { get; set; }
	}
}
