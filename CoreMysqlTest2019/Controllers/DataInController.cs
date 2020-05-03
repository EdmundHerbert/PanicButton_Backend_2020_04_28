using System;
using System.Collections.Generic;
using System.Linq;
using AdminPortal.HaloMysql;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
//using Remotion.Linq.Clauses;

namespace AdminPortal.Controllers
{
    [Route("api/DataIn")]
    [ApiController]
    public class DataInController : ControllerBase
    {
        readonly haloContext _db = new haloContext();

        [HttpGet]
        public ActionResult Get(Employees employees)
        {
            try {
                if (employees != null)
                {


                    if (String.IsNullOrEmpty(employees.HaloMemberIdnumber)) {
                        return BadRequest("Idnumber required");
                    }

                    if (String.IsNullOrEmpty(employees.HaloMemberCommand))
                    {
                        return BadRequest("Command required");
                    }

                    if (employees.HaloMemberClientId==null)
                    {
                        return BadRequest("clientId empty");
                    }


                    var members = new List<Halomembers>();
                    var existingMembers = _db.Halomembers.Where(s => s.HaloMemberIdnumber == employees.HaloMemberIdnumber)
                        .OrderBy(s => s.HaloMemberSurname);

                    foreach (var halomembers in existingMembers) {
                        members.Add(halomembers);
                    }
                        
                    

                    if (members.Count < 1)
                    {
                        if (employees.HaloMemberCommand == "ADD" && employees.HaloMemberClientId != 0)
                        {
                            var employeeData = new Halomembers();
                            var memberPhones = new Halomemberphonenumbers();
                            var memberClientMembers = new Haloclientmembers();

                            employeeData.HaloMemberName = employees.HaloMemberName;
                            employeeData.HaloMemberSurname = employees.HaloMemberSurname;
                            employeeData.HaloMemberGender = employees.HaloMemberGender;
                            employeeData.HaloMemberIdtype = employees.HaloMemberIdtype;
                            employeeData.HaloMemberIdnumber = employees.HaloMemberIdnumber;
                            employeeData.HaloMemberHomePhoneNumber = employees.HaloMemberHomePhoneNumber;
                            employeeData.HaloMemberWorkPhoneNumber = employees.HaloMemberWorkPhoneNumber;
                            employeeData.HaloMemberDataKey = employees.HaloMemberDataKey.ToString();
                            employeeData.HaloMemberActive = 1;
                            employeeData.HaloMemberActivateDate = DateTime.Now;
                            employeeData.HaloMemberLoadDate = DateTime.Now;
                            employeeData.HaloMemberAllergies = employees.HaloMemberAllergies;
                            employeeData.HaloMemberBloodType = employees.HaloMemberBloodType;
                            employeeData.HaloMemberMedicalAidName = employees.HaloMemberMedicalAidName;
                            employeeData.HaloMemberMedicalAidNumber = employees.HaloMemberMedicalAidNumber;
                            employeeData.HaloMemberMedicalAidScheme = employees.HaloMemberMedicalAidScheme;
                            employeeData.HaloMemberEmergencyContactName1 = employees.HaloMemberEmergencyContactName1;
                            employeeData.HaloMemberEmergencyContactNumber1 = employees.HaloMemberEmergencyContactNumber1;
                            employeeData.HaloMemberHomeAddress = employees.HaloMemberHomeAddress;

                            _db.Halomembers.Add(employeeData);
                            _db.SaveChanges();

                            memberClientMembers.HaloClientId = employees.HaloMemberClientId;
                            memberClientMembers.HaloMemberId = employeeData.HaloMemberId;

                            _db.Haloclientmembers.Add(memberClientMembers);
                            _db.SaveChanges();

                            memberPhones.HaloMemberId = employeeData.HaloMemberId;
                            memberPhones.HaloMemberPhoneNumber = employees.HaloMemberCellNumber;

                            _db.Halomemberphonenumbers.Add(memberPhones);
                            _db.SaveChanges();
                            return Ok("ADD SUCCESSFUL");
                        }
                        else
                        {
                            return BadRequest("No add command or clientId empty");
                            //return "No add command or clientId empty";
                        }
                    }
                    else { 

                    if (employees.HaloMemberCommand == "EDIT") //&& employees.HaloMemberActive == 1 &&
                                                               //employees.HaloMemberDataKey == 0)
                    {



                        var phoneData = (from ep in _db.Halomembers
                                         join a in _db.Halomemberphonenumbers on ep.HaloMemberId equals a.HaloMemberId
                                         where ep.HaloMemberIdnumber == employees.HaloMemberIdnumber
                                         select a);

                        foreach (var pn in phoneData)
                        {
                            pn.HaloMemberPhoneNumber = employees.HaloMemberCellNumber;
                            _db.Entry(pn).State = EntityState.Modified;
                        }


                        _db.SaveChanges();

                        var membersEditData = new List<Halomembers>();
                        foreach (var halomembers in (_db.Halomembers.Where(s => s.HaloMemberIdnumber == employees.HaloMemberIdnumber)
                            .OrderBy(s => s.HaloMemberSurname))) membersEditData.Add(halomembers);


                        foreach (var memEdit in membersEditData)
                        {
                            memEdit.HaloMemberName = employees.HaloMemberName;
                            memEdit.HaloMemberSurname = employees.HaloMemberSurname;
                            memEdit.HaloMemberHomeAddress = employees.HaloMemberHomeAddress;
                           // memEdit.HaloMemberDataKey = employees.HaloMemberDataKey;
                            memEdit.HaloMemberEmergencyContactName1 = employees.HaloMemberEmergencyContactName1;
                            memEdit.HaloMemberEmergencyContactNumber1 = employees.HaloMemberEmergencyContactNumber1;
                            memEdit.HaloMemberMedicalAidNumber = employees.HaloMemberMedicalAidNumber;
                            memEdit.HaloMemberMedicalAidScheme = employees.HaloMemberMedicalAidScheme;
                            memEdit.HaloMemberEmailAddress = employees.HaloMemberEmailAddress;
                            memEdit.HaloMemberGender = employees.HaloMemberGender;
                            memEdit.HaloMemberIdtype = employees.HaloMemberIdtype;
                            memEdit.HaloMemberAllergies = employees.HaloMemberAllergies;
                            memEdit.HaloMemberHomePhoneNumber = employees.HaloMemberHomePhoneNumber;
                            memEdit.HaloMemberWorkPhoneNumber = employees.HaloMemberWorkPhoneNumber;
                            memEdit.HaloMemberBloodType = employees.HaloMemberBloodType;
                            memEdit.HaloMemberModifiedDate = DateTime.Now;

                            _db.Entry(memEdit).State = EntityState.Modified;
                        }

                        _db.SaveChanges();

                            return Ok("EDIT SUCCESSFUL");
                        }


                    if (employees.HaloMemberCommand == "DELETE")// && employees.HaloMemberDataKey == 0)
                    {
                        var membersData = new List<Halomembers>();

                        foreach (var halomembers in (_db.Halomembers.Where(s => s.HaloMemberIdnumber == employees.HaloMemberIdnumber)
                            .OrderBy(s => s.HaloMemberSurname))) membersData.Add(halomembers);

                        foreach (var mem in membersData)
                        {
                            mem.HaloMemberDataKey = "1";
                            mem.HaloMemberActive = 0;
                            mem.HaloMemberModifiedDate = DateTime.Now;

                            _db.Entry(mem).State = EntityState.Modified;

                        }

                        _db.SaveChanges();
                            return Ok("DELETE SUCCESSFUL");
                    }
                    }
                }

                return BadRequest();
            }
            catch (Exception ex) {

                return StatusCode(Microsoft.AspNetCore.Http.StatusCodes.Status500InternalServerError);
            }
           

        }
    }
}

public class Employees
{
    ////public int HaloMemberId { get; set; }
    public string HaloMemberName { get; set; }
    public string HaloMemberSurname { get; set; }
    public string HaloMemberIdnumber { get; set; } // used to identify that record is ValueBuddy record * is added to end of Id
    public long? HaloMemberClientId { get; set; }
    //public string HaloMemberProgramId { get; set; }
    public string HaloMemberValueBuddyToken { get; set; }
    public string HaloMemberCommand { get; set; }
    public string HaloMemberCellNumber { get; set; }

    //public string HaloMemberPassword { get; set; }
    //public string HaloMemberOtp { get; set; }
    //public string HaloMemberToken { get; set; }
    public string HaloMemberEmailAddress { get; set; }
    public string HaloMemberLanguage { get; set; }
    public string HaloMemberGender { get; set; }
    public string HaloMemberIdtype { get; set; }
    //public string HaloMemberDateOfBirth { get; set; }
    public string HaloMemberHomePhoneNumber { get; set; }
    public string HaloMemberWorkPhoneNumber { get; set; }
    public string HaloMemberMedicalAidName { get; set; }
    public string HaloMemberMedicalAidNumber { get; set; }
    public string HaloMemberMedicalAidScheme { get; set; }
    public string HaloMemberHomeAddress { get; set; }
    public string HaloMemberWorkAddress { get; set; }
    public string HaloMemberEmergencyContactName1 { get; set; }
    public string HaloMemberEmergencyContactNumber1 { get; set; }
    //public string HaloMemberEmergencyContactName2 { get; set; }
    //public string HaloMemberEmergencyContactNumber2 { get; set; }
    //public string HaloMemberOccupation { get; set; }
    //public string HaloMemberBusinessName { get; set; }
    public string HaloMemberBloodType { get; set; }
    //public string HaloMemberBloodDonorNumber { get; set; }
    public string HaloMemberAllergies { get; set; }
    public string HaloMemberLatitude { get; set; }
    public string HaloMemberLongitude { get; set; }
    //public string HaloMemberImage { get; set; }
    public short? HaloMemberActive { get; set; }    // used to determine if ValueBuddy record is active
    public string HaloMemberDataKey { get; set; }   // used to determine if ValueBuddy record is archived/deleted 
    public DateTimeOffset? HaloMemberLoadDate { get; set; }
    public DateTimeOffset? HaloMemberActivateDate { get; set; }
    public DateTimeOffset? HaloMemberModifiedDate { get; set; } // used to store date ValueBuddy record was archived/deleted
                                                                //public string HaloMemberFullName { get; set; }
}
