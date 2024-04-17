Let's play with Unity.

Start with substrate and your node ...

git clone https://github.com/substrate-developer-hub/substrate-node-template
cargo build --release
./target/release/node-template --dev



Creating the Solution

mkdir Substrate.NodeTemplate.NET
cd .\Substrate.NodeTemplate.NET\
dotnet new sln
dotnet new install Substrate.DotNet.Template # current ver. 0.6.2

dotnet new substrate --sdk_version 0.6.2 --rest_service Substrate.NodeTemplate.NET.RestService --net_api Substrate.NodeTemplate.NET.NetApiExt --net_integration Substrate.NodeTemplate.NET.Integration --rest_client Substrate.NodeTemplate.NET.RestClient --metadata_websocket ws://127.0.0.1:9944 --force --allow-scripts yes

Explorer
https://polkadot.js.org/apps/?rpc=ws%3A%2F%2F127.0.0.1%3A9944#/explorer


- Elements of the solution
- What shall I use
- How do I use it

Implement and use Unity