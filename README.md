## Benchmark Hot Chocolate GraphQL engine in memory

### Demo from Get started with Hot Chocolate V 11

### How to test
- Install autocannon tool
- npm i autocannon -g

### Command
- autocannon -m 'POST' -b '{ "query": "{ book { title author { name } } }" }' -H "Content-Type: application/json" http://localhost:5000/graphql

### Results

#### Autocannon
![alt text](https://github.com/LeandroRezendeCoutinho/DemoGraph/blob/master/img/GraphQlBench.png)

#### Memory and CPU
![alt text](https://github.com/LeandroRezendeCoutinho/DemoGraph/blob/master/img/CPUMEMBench.png)

#### CPU
![alt text](https://github.com/LeandroRezendeCoutinho/DemoGraph/blob/master/img/CPUBench.png)

#### Best results forcing high concurrency
![alt text](https://github.com/LeandroRezendeCoutinho/DemoGraph/blob/master/img/BestResult.png)

- In this cenario memory don't change but uses 85% of CPU. Rest of CPU was used by autocannon.

#### Forcing even more pipeline 1000 concurrency 100
![alt text](https://github.com/LeandroRezendeCoutinho/DemoGraph/blob/master/img/dotnet_hotchocolate_bench.png)

### Server resources

### Hardware
- Ryzen 7 2700
- 16GB DDR4 2933 Mhz