using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipClassVersion
{
    class ship
    {
        //enum
        public enum ShipType
        { Carrier, Battleship, Courier, Submarines, Minesweeper }

        //properties
        public ShipType Type { get; set; }
        public int Length { get; set; }
        public List<Points> OccupiedPoints { get; set; }
        public bool IsDestroyed
        {
            get ( return OccupiedPoints.All(x => x.GCNotificationStatus == Points.PointStatus.Hit));
        }
    }
}
