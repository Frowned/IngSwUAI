﻿using BE.DTO;
using BE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interfaces.DAL
{
    public interface IProductDAL
    {
        IList<Category> GetCategories();
        IList<ProductDTO> GetProducts(bool showAll = true);
        void DeleteProduct(int id);
        void AddProduct(ProductDTO productDTO);
    }
}
