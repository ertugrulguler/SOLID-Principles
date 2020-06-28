﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.InterfaceSegregation.Interfaces
{
    interface IBaseApi:IGet
    {
        void Put(int id);
        void Delete(int id);
        void Post(int id);
    
    }
}
