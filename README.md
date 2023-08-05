# MinerCON
The rcon library warpper, almost all code is taken from [here](https://github.com/willroberts/minecraft-client-csharp),
huge thanks to the creator of it.
## Set-Up
To properly set-up Rcon on your server read [this article](https://wiki.vg/RCON)
## Usage
To initialize it create a new `RconConnection`,
then
```
RconConnection.Login(Adress, Port, Password)
```
Afterwards you will see `rcon theread started on {adress}` in your server console,
this means you set up everything correctly.

To send a command use
```
RconConnection.SendCommand(command)
```
Note that you should write commands without slash at the beginning for them to properly work.

To properly close connection use
```
RconConnection.Dispose()
```
it will close the client.
### Important
Do not try to use Login while the connection is active, make sure you properly closed it.

Errors are mostly handeled within but some (Mostly NullReference) need to be handled is your application.

The library can support multiple servers at once, just create a separate instance
of RconConnection
