﻿#region

using Bade.Constants;
using Bade.Data.Contract;
using Bade.Entity.Domain;
using Bade.Infrastructure;

#endregion

namespace Bade.Data.Dapper
{
    public class RouteRepository : Repository, IRouteRepository
    {


        public RouteRepository(IConnectionFactory connectionFactory)
            : base(connectionFactory, Constant.DefaultConnectionStringName)
        {
            
        }
    }
}