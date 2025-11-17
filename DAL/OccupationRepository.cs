using System.Collections.Generic;
namespace CapgeminiTest.DAL {
    public class OccupationRepository : IRepository<string> {
        List<string> occ = new List<string>{ "Cleaner","Doctor","Author","Farmer","Mechanic","Florist","Other" };
        public IEnumerable<string> GetAll()=>occ;
        public string Get(int id)=>occ[id];
        public void Add(string e)=>occ.Add(e);
    }
}