# SqliteWasmDbContextFactory&lt;TContext&gt; constructor

Initializes a new instance of the [`SqliteWasmDbContextFactory`](../SqliteWasmDbContextFactory-1.md) class.
```csharp
public SqliteWasmDbContextFactory(IDbContextFactory<TContext> dbContextFactory, 
    IBrowserCache cache, ISqliteSwap swap)
```
| parameter | description |
| --- | --- |
| dbContextFactory | The EF Core-provided factory. |
| cache | The [`BrowserCache`](../BrowserCache.md) helper. |
| swap | Service to perform the backup. |
## See Also
* interface [IBrowserCache](../IBrowserCache.md)
* interface [ISqliteSwap](../ISqliteSwap.md)
* class [SqliteWasmDbContextFactory&lt;TContext&gt;](../SqliteWasmDbContextFactory-1.md)
* namespace [SqliteWasmHelper](../../SqliteWasmHelper.md)
<!-- DO NOT EDIT: generated by xmldocmd for SqliteWasmHelper.dll -->


Version 1.1.1-beta+f8529a4633 generated on 06/22/2022 16:28:40.