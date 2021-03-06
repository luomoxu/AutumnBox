﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AutumnBox.OpenFramework.Open
{
    /// <summary>
    /// 持久化存储API
    /// </summary>
    public interface IStorage
    {
        /// <summary>
        /// 根据ID打开一个文件
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="createIfNotExist"></param>
        /// <exception cref="FileNotFoundException">文件未找到</exception>
        /// <returns></returns>
        FileStream OpenFile(string fileId, bool createIfNotExist = true);
        /// <summary>
        /// 将一个Stream写入文件
        /// </summary>
        /// <param name="srcSource">源Stream</param>
        /// <param name="fileId">文件ID</param>
        /// <returns>写入完成后,返回文件的信息</returns>
        FileInfo WriteToFile(Stream srcSource, string fileId = null);
        /// <summary>
        /// 删除一个文件
        /// </summary>
        /// <param name="fileId"></param>
        void DeleteFile(string fileId);
        /// <summary>
        /// 保存一个JsonObject
        /// </summary>
        /// <param name="jsonId"></param>
        /// <param name="jsonObject"></param>
        void SaveJsonObject(string jsonId, object jsonObject);
        /// <summary>
        /// 读取一个JsonObject
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="jsonId"></param>
        /// <returns>读取失败则返回NULL,否则返回序列化值</returns>
        TResult ReadJsonObject<TResult>(string jsonId);
        /// <summary>
        /// 缓存文件夹信息
        /// </summary>
        DirectoryInfo CacheDirectory { get; }
        /// <summary>
        /// 删除保存的Json
        /// </summary>
        void ClearJsonObjects();
        /// <summary>
        /// 清空缓存文件夹
        /// </summary>
        void ClearCache();
        /// <summary>
        /// 清空单文件存储系统
        /// </summary>
        void ClearFiles();
        /// <summary>
        /// 清空全部
        /// </summary>
        void Restore();
    }
}
