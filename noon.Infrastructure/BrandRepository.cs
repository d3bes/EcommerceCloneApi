﻿using Microsoft.EntityFrameworkCore;
using noon.Application.Contract;
using noon.Context.Context;
using noon.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noon.Infrastructure
{
    public class BrandRepository : Repositoy<ProductBrand, int>, IBrandRepository
    {
        private readonly noonContext noonContext;

        public BrandRepository(noonContext noonContext) : base(noonContext)
        {
            this.noonContext = noonContext;
        }

        public async Task<IEnumerable<ProductBrand>> FilterByAsync(string filter, int id)
        {
            return noonContext.ProductBrands.Where(a => (a.name.ToLower().Contains(filter.ToLower()) || a.name.Contains(filter)))
                .Where(a => id == null ? true : a.id == id);
        }


        public override async Task<ProductBrand?> GetDetailsAsync(int id)
        {
            return noonContext.ProductBrands.Where(a => a.id == id).Include(a => a.products).ThenInclude(x => x.images).FirstOrDefault();
        }
    }

}