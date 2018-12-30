﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SimpleDomain.EventStore.Persistence {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class SqlCommands {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SqlCommands() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SimpleDomain.EventStore.Persistence.SqlCommands", typeof(SqlCommands).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to IF (OBJECT_ID(&apos;Events&apos;, &apos;U&apos;) IS NULL) 
        ///BEGIN
        ///	CREATE TABLE dbo.Events
        ///	(
        ///		[AggregateType]		[VARCHAR](255)		NOT NULL,
        ///		[AggregateId]		[UNIQUEIDENTIFIER]	NOT NULL,
        ///		[Version]			[INT]				NOT NULL,
        ///		[Timestamp]			[DATETIME]			NOT NULL,
        ///		[EventType]			[NVARCHAR](255)		NOT NULL,
        ///		[EventData]			[NVARCHAR](MAX)		NOT NULL,
        ///		[Headers]			[NVARCHAR](MAX)		NULL,
        ///		CONSTRAINT PK_Events PRIMARY KEY CLUSTERED ([AggregateType], [AggregateId], [Version] ASC) ON [PRIMARY]
        ///	) ON [PRIMARY];
        ///END.
        /// </summary>
        public static string CreateEventsTable {
            get {
                return ResourceManager.GetString("CreateEventsTable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to IF (OBJECT_ID(&apos;Snapshots&apos;, &apos;U&apos;) IS NULL) 
        ///BEGIN
        ///	CREATE TABLE dbo.Snapshots
        ///	(
        ///		[AggregateType]		[VARCHAR](255)		NOT NULL,
        ///		[AggregateId]		[UNIQUEIDENTIFIER]	NOT NULL,
        ///		[Version]			[INT]				NOT NULL,
        ///		[Timestamp]			[DATETIME]			NOT NULL,
        ///		[SnapshotType]		[NVARCHAR](255)		NOT NULL,
        ///		[SnapshotData]		[NVARCHAR](MAX)		NOT NULL,
        ///		CONSTRAINT PK_Snapshots PRIMARY KEY CLUSTERED ([AggregateType], [AggregateId], [Version] ASC) ON [PRIMARY]
        ///	) ON [PRIMARY];
        ///END.
        /// </summary>
        public static string CreateSnapshotsTable {
            get {
                return ResourceManager.GetString("CreateSnapshotsTable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT [EventData], [EventType]
        ///FROM
        ///(
        ///	SELECT ROW_NUMBER() OVER(ORDER BY [Timestamp]) AS RowNum, [EventData], [EventType]
        ///	FROM dbo.Events
        ///) AS RowConstrainedResult
        ///WHERE RowNum &gt; @LowerBound AND RowNum &lt;= @UpperBound.
        /// </summary>
        public static string GetAllEvents {
            get {
                return ResourceManager.GetString("GetAllEvents", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT [EventData], [EventType]
        ///FROM dbo.Events 
        ///WHERE [AggregateType] = @AggregateType 
        ///AND [AggregateId] = @AggregateId
        ///AND [Version] BETWEEN @VersionFrom AND @VersionTo
        ///ORDER BY [Version].
        /// </summary>
        public static string GetEventsByVersion {
            get {
                return ResourceManager.GetString("GetEventsByVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT TOP 1 [SnapshotData], [SnapshotType]
        ///FROM dbo.Snapshots
        ///WHERE [AggregateType] = @AggregateType
        ///AND [AggregateId] = @AggregateId
        ///ORDER BY [Version] DESC.
        /// </summary>
        public static string GetLatestSnapshot {
            get {
                return ResourceManager.GetString("GetLatestSnapshot", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT COUNT(*) 
        ///FROM dbo.Snapshots 
        ///WHERE [AggregateType] = @AggregateType 
        ///AND [AggregateId] = @AggregateId.
        /// </summary>
        public static string GetSnapshotCount {
            get {
                return ResourceManager.GetString("GetSnapshotCount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT dbo.Events ([AggregateType], [AggregateId], [Version], [Timestamp], [EventType], [EventData], [Headers])
        ///VALUES(@AggregateType, @AggregateId, @Version, @Timestamp, @EventType, @EventData, @Headers).
        /// </summary>
        public static string InsertEvent {
            get {
                return ResourceManager.GetString("InsertEvent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT dbo.Snapshots ([AggregateType], [AggregateId], [Version], [Timestamp], [SnapshotType], [SnapshotData])
        ///VALUES(@AggregateType, @AggregateId, @Version, @Timestamp, @SnapshotType, @SnapshotData).
        /// </summary>
        public static string InsertSnapshot {
            get {
                return ResourceManager.GetString("InsertSnapshot", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DELETE dbo.Events
        ///WHERE [AggregateType] = @AggregateType 
        ///AND [AggregateId] = @AggregateId.
        /// </summary>
        public static string ResetAggregateByTypeAndId {
            get {
                return ResourceManager.GetString("ResetAggregateByTypeAndId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DELETE dbo.Events
        ///WHERE [AggregateType] = @AggregateType.
        /// </summary>
        public static string ResetAllAggregatesByType {
            get {
                return ResourceManager.GetString("ResetAllAggregatesByType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DELETE dbo.Events.
        /// </summary>
        public static string TruncateEvents {
            get {
                return ResourceManager.GetString("TruncateEvents", resourceCulture);
            }
        }
    }
}