using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;

namespace YooAsset.Editor
{
	[Serializable]
	public class ReportSummary
	{
		/// <summary>
		/// 引擎版本
		/// </summary>
		public string UnityVersion;

		/// <summary>
		/// 构建时间
		/// </summary>
		public string BuildTime;
		
		/// <summary>
		/// 构建耗时（单位：秒）
		/// </summary>
		public int BuildSeconds;

		/// <summary>
		/// 构建平台
		/// </summary>
		public BuildTarget BuildTarget;

		/// <summary>
		/// 构建版本
		/// </summary>
		public int BuildVersion;

		/// <summary>
		/// 启用自动分包机制
		/// </summary>
		public bool EnableAutoCollect;

		/// <summary>
		/// 追加文件扩展名
		/// </summary>
		public bool AppendFileExtension;

		/// <summary>
		/// 自动收集着色器
		/// </summary>
		public bool AutoCollectShaders;

		/// <summary>
		/// 自动收集的着色器资源包名
		/// </summary>
		public string ShadersBundleName;

		// 构建参数
		public bool ForceRebuild;
		public string BuildinTags;
		public ECompressOption CompressOption;
		public bool AppendHash;
		public bool DisableWriteTypeTree;
		public bool IgnoreTypeTreeChanges;
		public bool DisableLoadAssetByFileName;

		// 构建结果
		public int AssetFileTotalCount;
		public int RedundancyAssetFileCount;
		public int AllBundleTotalCount;
		public long AllBundleTotalSize;
		public int BuildinBundleTotalCount;
		public long BuildinBundleTotalSize;
		public int EncryptedBundleTotalCount;
		public long EncryptedBundleTotalSize;
		public int RawBundleTotalCount;
		public long RawBundleTotalSize;
	}
}