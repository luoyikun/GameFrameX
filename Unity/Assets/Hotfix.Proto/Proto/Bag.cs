﻿using System;
using MessagePack;
using System.Collections.Generic;
using GameFramework.Network;

namespace Hotfix.Proto.Proto
{
	/// <summary>
	/// 请求背包数据
	/// </summary>
	[MessageTypeHandler(100)]
	[MessagePackObject(true)]
	public partial class ReqBagInfo : MessageObject, IRequestMessage
	{
	}

	/// <summary>
	/// 返回背包数据
	/// </summary>
	[MessageTypeHandler(100)]
	[MessagePackObject(true)]
	public partial class ResBagInfo : MessageObject, IResponseMessage
	{
		/// <summary>
		/// 
		/// </summary>
		public Dictionary<int, long> ItemDic { get; set; }

	}

	/// <summary>
	/// 请求背包数据
	/// </summary>
	[MessageTypeHandler(101)]
	[MessagePackObject(true)]
	public partial class ReqComposePet : MessageObject, IRequestMessage
	{
		/// <summary>
		///  碎片id
		/// </summary>
		public int FragmentId { get; set; }

	}

	/// <summary>
	/// 返回背包数据
	/// </summary>
	[MessageTypeHandler(101)]
	[MessagePackObject(true)]
	public partial class ResComposePet : MessageObject, IResponseMessage
	{
		/// <summary>
		///  合成宠物的Id
		/// </summary>
		public int PetId { get; set; }

	}

	/// <summary>
	/// 请求背包数据
	/// </summary>
	[MessageTypeHandler(102)]
	[MessagePackObject(true)]
	public partial class ReqUseItem : MessageObject, IRequestMessage
	{
		/// <summary>
		///  道具id
		/// </summary>
		public int ItemId { get; set; }

	}

	/// <summary>
	/// 出售道具
	/// </summary>
	[MessageTypeHandler(103)]
	[MessagePackObject(true)]
	public partial class ReqSellItem : MessageObject, IRequestMessage
	{
		/// <summary>
		///  道具id
		/// </summary>
		public int ItemId { get; set; }

	}

	/// <summary>
	/// 出售道具
	/// </summary>
	[MessageTypeHandler(103)]
	[MessagePackObject(true)]
	public partial class ResItemChange : MessageObject, IResponseMessage
	{
		/// <summary>
		///  变化的道具
		/// </summary>
		public Dictionary<int, long> ItemDic { get; set; }

	}

}
