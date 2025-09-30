﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Education
	{
		[Key]
		public int EducationID { get; set; }
		public string EducationName { get; set; }
		public string EducationGPA { get; set; }
		public DateTime EducationDate { get; set; }
		public string EducationDescription { get; set; }
	}
}
