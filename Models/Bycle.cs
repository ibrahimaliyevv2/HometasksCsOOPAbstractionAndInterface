using System;
namespace Models
{
    public class Bycle:Vehicle
    {
        public override void Drive()
        {
            Millage++;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
        }
    }
}
