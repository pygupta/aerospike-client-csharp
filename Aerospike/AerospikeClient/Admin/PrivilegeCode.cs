/* 
 * Copyright 2012-2022 Aerospike, Inc.
 *
 * Portions may be licensed to Aerospike, Inc. under one or more contributor
 * license agreements.
 *
 * Licensed under the Apache License, Version 2.0 (the "License"); you may not
 * use this file except in compliance with the License. You may obtain a copy of
 * the License at http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
 * WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the
 * License for the specific language governing permissions and limitations under
 * the License.
 */

namespace Aerospike.Client
{
	/// <summary>
	/// Permission codes define the type of permission granted for a user's role.
	/// </summary>
	public enum PrivilegeCode
	{
		/// <summary>
		/// User can edit/remove other users.  Global scope only.
		/// </summary>
		USER_ADMIN = 0,

		/// <summary>
		/// User can perform systems administration functions on a database that do not involve user
		/// administration.  Examples include server configuration.
		/// Global scope only.
		/// </summary>
		SYS_ADMIN = 1,

		/// <summary>
		/// User can perform UDF and SINDEX administration actions. Global scope only.
		/// </summary>
		DATA_ADMIN = 2,

		/// <summary>
		/// User can perform user defined function(UDF) administration actions.
		/// Examples include create/drop UDF. Global scope only.
		/// Requires server version 6.0+
		/// </summary>
		UDF_ADMIN = 3,

		/// <summary>
		/// User can perform secondary index administration actions.
		/// Examples include create/drop index. Global scope only.
		/// Requires server version 6.0+
		/// </summary>
		SINDEX_ADMIN = 4,

		/// <summary>
		/// User can read data.
		/// </summary>
		READ = 10,

		/// <summary>
		/// User can read and write data.
		/// </summary>
		READ_WRITE = 11,

		/// <summary>
		/// User can read and write data through user defined functions.
		/// </summary>
		READ_WRITE_UDF = 12,

		/// <summary>
		/// User can write data.
		/// </summary>
		WRITE = 13,

		/// <summary>
		/// User can truncate data.
		/// Requires server version 6.0+
		/// </summary>
		TRUNCATE = 14
	}
}
