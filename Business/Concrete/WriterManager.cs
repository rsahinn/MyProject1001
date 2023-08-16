﻿using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
	
	public class WriterManager : IWriterService
	{
		IWriterDal _writerdal;

		public WriterManager(IWriterDal writerDal) 
		{
			_writerdal=writerDal;
		}
		
		public void AddWriter(Writer writer)
		{
			_writerdal.Add(writer);
		}
	}
}
