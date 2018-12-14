﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SmartSql.DyRepository
{
    public interface IDelete<TPrimary>
    {
        int Delete(object reqParams);
        [Statement(Id = "Delete")]
        int DeleteById([Param("Id")]TPrimary id);
    }

    public interface IDeleteAsync<TPrimary>
    {
        Task<int> DeleteAsync(object reqParams);
        [Statement(Id = "Delete")]
        Task<int> DeleteByIdAsync([Param("Id")]TPrimary id);
    }
}
