﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevProjectDataModels;

namespace DevProjectDataLayer
{
    public interface IProject
    {
        List<ProductDTO> GetAllProducts();
    }
}