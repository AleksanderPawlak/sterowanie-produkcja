using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyznaczanie_Optymalnej_Trasy.Algorithms.utils
{
    class RandomCoordinates
    {
        // TODO: change solution
        private static Coordinates[] PolandPolygon = new Coordinates[] {
            new Coordinates(new Decimal(53.406322), new Decimal(14.558969)),
            new Coordinates(new Decimal(52.875082), new Decimal(14.381287)),
            new Coordinates(new Decimal(52.580432), new Decimal(14.825624)),
            new Coordinates(new Decimal(51.100049), new Decimal(15.160069)),
            new Coordinates(new Decimal(50.665466), new Decimal(16.451800)),
            new Coordinates(new Decimal(50.370268), new Decimal(17.800895)),
            new Coordinates(new Decimal(49.691728), new Decimal(19.240045)),
            new Coordinates(new Decimal(50.065639), new Decimal(19.910652)),
            new Coordinates(new Decimal(52.227967), new Decimal(21.038892)),
            new Coordinates(new Decimal(53.122915), new Decimal(18.008129))
        };
        private static double PolandMinLatitude = 14.381287;
        private static double PolandMaxLatitude = 21.038892;
        private static double PolandMinLongitude = 49.691728;
        private static double PolandMaxLongitude = 53.406322;
        private static Random rng = new Random();


        //private static int NextInt32()
        //{
        //    int firstBits = rng.Next(0, 1 << 4) << 28;
        //    int lastBits = rng.Next(0, 1 << 28);
        //    return firstBits | lastBits;
        //}

        //private static decimal NextDecimal()
        //{
        //    byte scale = (byte)rng.Next(29);
        //    bool sign = rng.Next(2) == 1;
        //    return new decimal(
        //        NextInt32(),
        //        NextInt32(),
        //        NextInt32(),
        //        sign,
        //        scale
        //        );
        //}

        private static Coordinates GetRandomCoorinates()
        {
            decimal longitude = Decimal.Round((decimal)(PolandMinLongitude + (rng.NextDouble() * (PolandMaxLongitude - PolandMinLongitude))), 6);
            decimal latitude = Decimal.Round((decimal)(PolandMinLatitude + (rng.NextDouble() * (PolandMaxLatitude - PolandMinLatitude))), 6);

            return new Coordinates(longitude, latitude);
        }

        private static bool IsInPolygon(Coordinates[] poly, Coordinates point)
        {
            var coef = poly.Skip(1).Select(
                (p, i) =>
                (decimal)(point.longitude - poly[i].longitude) * (p.latitude - poly[i].latitude)
                - (point.latitude - poly[i].latitude) * (p.longitude - poly[i].longitude))
                .ToList();

            if (coef.Any(p => p == 0))
                return true;

            for (int i = 1; i < coef.Count(); i++)
            {
                if (coef[i] * coef[i - 1] < 0)
                    return false;
            }
            return true;
        }

        private static bool IsPointInPolygon4(Coordinates[] polygon, Coordinates testPoint)
        {
            bool result = false;
            int j = polygon.Count() - 1;
            for (int i = 0; i < polygon.Count(); i++)
            {
                if (polygon[i].longitude < testPoint.longitude && polygon[j].longitude >= testPoint.longitude || polygon[j].longitude < testPoint.longitude && polygon[i].longitude >= testPoint.longitude)
                {
                    if (polygon[i].latitude + (testPoint.longitude - polygon[i].longitude) / (polygon[j].longitude - polygon[i].longitude) * (polygon[j].latitude - polygon[i].latitude) < testPoint.latitude)
                    {
                        result = !result;
                    }
                }
                j = i;
            }
            return result;
        }

        public static Coordinates GetRandomCoordinatesInPoland()
        {
            Coordinates result = GetRandomCoorinates(); ;
            while (!IsInPolygon(PolandPolygon, result))
            {
                result = GetRandomCoorinates();
            }

            return result;
        }

    }
}
