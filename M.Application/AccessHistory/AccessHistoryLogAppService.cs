﻿using M.Helper.Model;
using M.Model.Db;
using M.Model.Entity;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace M.Application.AccessHistory
{
    /// <summary>
    /// 访问日志服务
    /// </summary>
    [Route("api/AccessHistoryLogAppService")]
    [ApiController]
    [EnableCors("CustomCorsPolicy")]
    //[HiddenApi]
    public class AccessHistoryLogAppService
    {
        private readonly FangHuaHostDbContext _context;

        public AccessHistoryLogAppService(FangHuaHostDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// 添加访问日志
        /// </summary>
        /// <param name="accessHistoryLog"></param>
        [HttpPost("CreateAccessHistoryLog")]
        public async Task<ResultDto> CreateAccessHistoryLog(AccessHistoryLog accessHistoryLog)
        {
            await _context.AccessHistoryLog.AddAsync(accessHistoryLog);
            return new ResultDto()
            {
                Success = await _context.SaveChangesAsync() > 0 ? true : false
            };
        }
    }
}