﻿using System;
using System.Collections.Generic;

namespace ParkPass
{
public class BadRequestResponse
	{

		public string Message { get; set; }
		public Dictionary<string, string[]> ModelState { get; set; }
	}
}

