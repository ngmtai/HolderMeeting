﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;
using System.Linq;
using BLL.Model;
using DAL;

namespace BLL
{
    public class HolderBusiness
    {
        private readonly HolderMeetingEntities _holderMeetingEntities;

        public HolderBusiness()
        {
            _holderMeetingEntities = new HolderMeetingEntities();
        }

        /// <summary>
        /// Save holder
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <history>
        /// 12/6/2014 aBc: create new
        /// </history>
        public int Save(Holder model)
        {
            try
            {
                _holderMeetingEntities.Holders.Add(model);
                _holderMeetingEntities.SaveChanges();

                return model.Id;
            }
            catch
            {
            }

            return -1;
        }

        /// <summary>
        /// Save list Holder
        /// </summary>
        /// <param name="lst"></param>
        /// <returns></returns>
        /// <history>
        /// 12/21/2014 aBc: create new
        /// </history>
        public bool Saves(List<Holder> lst)
        {
            try
            {
                _holderMeetingEntities.Holders.AddRange(lst);
                _holderMeetingEntities.SaveChanges();

                return true;
            }
            catch {}

            return false;
        }

        /// <summary>
        /// Check code and name and authorizerName is exist
        /// </summary>
        /// <param name="code"></param>
        /// <param name="name"></param>
        /// <param name="authorizerName"></param>
        /// <returns></returns>
        /// <history>
        /// 12/21/2014 aBc: create new
        /// </history>
        public bool CheckExist(string code, string name, string authorizerName)
        {
            try
            {
                var aBc =
                    _holderMeetingEntities.Holders.FirstOrDefault(
                        t => t.Code.Equals(code) && t.Name.Equals(name) && t.AuthorizerName.Equals(authorizerName));

                return aBc != null && aBc.Id > 0;
            }
            catch {}

            return false;
        }

        /// <summary>
        /// Edit holder
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <history>
        /// 12/6/2014 aBc: create new
        /// </history>
        public bool Edit(Holder model)
        {
            try
            {
                var aBc = _holderMeetingEntities.Holders.SingleOrDefault(t => t.Id == model.Id && t.IsActive==true);
                if (aBc != null)
                {
                    aBc.AuthorizerName = model.AuthorizerName;
                    aBc.IsActive = model.IsActive;
                    aBc.Name = model.Name;
                    aBc.TotalShare = model.TotalShare;
                    aBc.UpdateDate = model.UpdateDate;
                    aBc.UpdateUser = model.UpdateUser;
                }

                _holderMeetingEntities.SaveChanges();
                return true;
            }
            catch { }

            return false;
        }

        /// <summary>
        /// Get holder detail
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <history>
        /// 12/6/2014 aBc: create new
        /// </history>
        public Holder Detail(int id)
        {
            try
            {
                var aBc = _holderMeetingEntities.Holders.SingleOrDefault(t => t.Id == id && t.IsActive==true);
                if (aBc != null) return aBc;
            }
            catch { }

            return new Holder();
        }

        /// <summary>
        /// Get list holder
        /// </summary>
        /// <returns></returns>
        /// <history>
        /// 12/6/2014 aBc: create new
        /// </history>
        public List<Holder> GetAlls()
        {
            try
            {
                var aBc = _holderMeetingEntities.Holders.Where(t => t.IsActive == true).OrderBy(t => t.Name);
                if (aBc.Any()) return aBc.ToList();
            }
            catch {}

            return new List<Holder>();
        }
    }
}
