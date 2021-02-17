using GameProject.Abstract;
using GameProject.Entities;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Adapters
{
    public class GamerCheckManager : IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            KPSPublicSoapClient kPSPublicSoapClient = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
            var result = kPSPublicSoapClient.TCKimlikNoDogrulaAsync(
                Convert.ToInt64(gamer.NationalityId),
                gamer.FirstName.ToUpper(),
                gamer.LastName.ToUpper(),
                gamer.DateOfBirth.Year);
            return result.Result.Body.TCKimlikNoDogrulaResult;


        }
        

    }
}
