using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITMCollegeService.DTO
{
    public class GetCollegeAddressDTO
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public byte IsMainFacility { get; set; }
        public int? CollegeId { get; set; }
        public string MapApi { get; set; }
    }
}
