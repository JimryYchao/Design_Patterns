namespace DesignPatterns_For_CSharp.Structural_Patterns.Composite
{
    public class Client
    {
        public Employee BuildATeam()
        {
            Employee boss = new Employee(false);
            boss.SetMessage("Tom", "man", 45, 50000);

            Employee chargeA = new Employee(false);
            chargeA.SetMessage("Lily", "woman", 25, 12000);
            Employee chargeB = new Employee(false);
            chargeB.SetMessage("Jerry", "man", 27, 11000);

            Employee baseA = new Employee(true);
            baseA.SetMessage("Lee", "woman", 21, 8000);
            Employee baseB = new Employee(true);
            baseB.SetMessage("Ychao", "man", 21, 7500);
            Employee baseC = new Employee(true);
            baseC.SetMessage("Tomas", "man", 22, 7000);
            Employee baseD = new Employee(true);
            baseD.SetMessage("Jimmy", "man", 23, 8200);

            boss.Add(chargeA, chargeB);
            chargeA.Add(baseA, baseB);
            chargeB.Add(baseC, baseD);
            return boss;
        }
        public void DoWork(Employee leader)
        {
            leader.Operation();
        }
    }
}
