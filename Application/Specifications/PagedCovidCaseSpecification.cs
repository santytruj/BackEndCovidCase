using Ardalis.Specification;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Specifications
{
    public class PagedCovidCaseSpecification : Specification<CovidCase>
    {
        public PagedCovidCaseSpecification(int pageSize, int pageNumber, string hash)
        {
            Query.Skip((pageNumber - 1) * pageSize)
                .Take(pageSize);

            if (!string.IsNullOrEmpty(hash))
                Query.Search(x => x.hash, "%" + hash + "%");


        }
    }
}
