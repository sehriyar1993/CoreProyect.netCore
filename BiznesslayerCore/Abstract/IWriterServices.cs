﻿using EntitylayerCore.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiznesslayerCore.Abstract
{
	public interface IWriterServices : IGenericServices<Writer>
	{
        List<Writer> GetWriterById(int id);
    }
}
