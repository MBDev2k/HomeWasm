# BrowserCache.SyncDbWithCacheAsync method

Calls the code to check save to/restore from cache.
```csharp
public Task<int> SyncDbWithCacheAsync(string filename)
```
| parameter | description |
| --- | --- |
| filename | The name of the file to process. |
## Return Value
Either -1 (no cache), 0 (restored), or 1 (cached).
## See Also
* class [BrowserCache](../BrowserCache.md)
* namespace [SqliteWasmHelper](../../SqliteWasmHelper.md)
<!-- DO NOT EDIT: generated by xmldocmd for SqliteWasmHelper.dll -->


Version 1.1.1-beta+f8529a4633 generated on 06/22/2022 16:28:40.