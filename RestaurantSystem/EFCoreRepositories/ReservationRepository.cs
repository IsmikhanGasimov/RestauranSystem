using RestaurantSystem.Entities;
using RestaurantSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.EFCoreRepositories
{
    internal class ReservationRepository:GenericRepository<Reservations>,IReservationRepository
    {

    }
}
