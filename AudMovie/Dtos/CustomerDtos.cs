﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AudMovie.Dtos
{
	public class CustomerDtos
	{
		public int Id { get; set; }

		[Required]
		[StringLength(255)]
		public string Name { get; set; }

		public bool IsSubscribedToNewsLetter { get; set; }

		public int MembershipTypeId { get; set; }

		public DateTime? BirthDate { get; set; }
	}
}