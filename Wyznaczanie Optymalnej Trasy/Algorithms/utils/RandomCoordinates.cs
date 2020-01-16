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
            new Coordinates(new Decimal(49.605623), new Decimal(19.916473)),
            new Coordinates(new Decimal(50.379392), new Decimal(17.960936)),
            new Coordinates(new Decimal(51.102191), new Decimal(15.197432)),
            new Coordinates(new Decimal(53.883667), new Decimal(14.395431)),
            new Coordinates(new Decimal(54.767876), new Decimal(18.182588)),
            new Coordinates(new Decimal(54.233981), new Decimal(18.672167)),
            new Coordinates(new Decimal(54.283231), new Decimal(22.909834)),
            new Coordinates(new Decimal(52.940740), new Decimal(23.766768)),
            new Coordinates(new Decimal(52.255619), new Decimal(23.039700)),
            new Coordinates(new Decimal(52.061320), new Decimal(23.415205)),
            new Coordinates(new Decimal(50.783761), new Decimal(23.728315)),
            new Coordinates(new Decimal(49.445322), new Decimal(22.272627)),
            new Coordinates(new Decimal(49.559477), new Decimal(21.547529)),
        };
        private static double PolandMinLatitude = 14.395431;
        private static double PolandMaxLatitude = 23.728315;
        private static double PolandMinLongitude = 49.605623;
        private static double PolandMaxLongitude = 54.767876;
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
            decimal longitude = (decimal)(PolandMinLongitude + (rng.NextDouble() * (PolandMaxLongitude - PolandMinLongitude)));
            decimal latitude = (decimal)(PolandMinLatitude + (rng.NextDouble() * (PolandMaxLatitude - PolandMinLatitude)));

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
