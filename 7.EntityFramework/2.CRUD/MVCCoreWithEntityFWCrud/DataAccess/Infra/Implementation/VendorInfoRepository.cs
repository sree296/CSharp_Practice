using DataAccess.Context;
using DataAccess.Infra.Abstract;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Infra.Implementation
{
    public class VendorInfoRepository : IVendorInfoRepository
    {
        VendorManagementContext _context = new VendorManagementContext();

        public List<VendorInfo> GetAllVendors()
        {
            List<VendorInfo> vendorlist = new List<VendorInfo>();

            try
            {
                vendorlist = _context.VendorDetailData.ToList();
            }
            catch (Exception ex)
            {
                string str = ex.Message;
            }


            return vendorlist;
        }

        public string InsertVerdorInfo(VendorInfo vendor)
        {   
            string responseMsg = string.Empty;

            try
            {
                _context.VendorDetailData.Add(vendor);
                _context.SaveChanges();

                if (vendor.VID > 0)
                {
                    responseMsg = "success";
                } 
                else
                {
                    responseMsg = "Data Insert Failed";
                }
            }
            catch (Exception ex)
            {
                responseMsg = ex.Message;
            }

            return responseMsg;
        }

        public string UpdateVendor(VendorInfo vendor)
        {
            string responseMsg = string.Empty;

            try
            {
                VendorInfo currentVendor = _context.VendorDetailData.FirstOrDefault(x => x.VID == vendor.VID);
                if (currentVendor != null)
                {
                    currentVendor.VName = vendor.VName;
                    currentVendor.Address = vendor.Address;
                    currentVendor.CityID = vendor.CityID;
                    _context.SaveChanges();

                    responseMsg = "success";
                }
                else
                {
                    responseMsg = "failed";
                }


            }
            catch (Exception ex)
            {
                responseMsg = "exception";
            }


            return responseMsg;
        }

        public VendorInfo GetVendorByVId(int vendorId)
        {
            VendorInfo vendorObj = new VendorInfo();

            try
            {
                vendorObj = _context.VendorDetailData.FirstOrDefault(x => x.VID == vendorId);
            }
            catch (Exception ex)
            {
                string str = ex.Message;
            }


            return vendorObj;
        }

        public string DeleteVendorByVendorId(int vendorId)
        {
            string responseMsg = string.Empty;
            try
            {
                VendorInfo currentVendor = _context.VendorDetailData.FirstOrDefault(x => x.VID == vendorId);
                if (currentVendor != null)
                { 
                    _context.VendorDetailData.Remove(currentVendor);
                    _context.SaveChanges();
                    responseMsg = "success";
                }
                else
                {
                    responseMsg = "failed";
                }

            }
            catch(Exception ex)
            {
                string str = ex.Message;
            }

            return responseMsg;
        }
    }
}
