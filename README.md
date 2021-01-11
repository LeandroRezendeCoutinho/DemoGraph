## Benchmark Hot Chocolate GraphQL engine in memory

### Demo from Get started with Hot Chocolate V 11

### How to test
- Install autocannon tool
- npm i autocannon -g

### Command
- autocannon -m 'POST' -b '{ "query": "{ book { title author { name } } }" }' -H "Content-Type: application/json" http://localhost:5000/graphql

### Results

#### Autocannon
![alt text](https://github.com/LeandroRezendeCoutinho/DemoGraph/GraphQlBench.png)

#### Memory and CPU
![alt text](https://github.com/LeandroRezendeCoutinho/DemoGraph/CPUMEMBench.png)

#### CPU
![alt text](https://github.com/LeandroRezendeCoutinho/DemoGraph/CPUBench.png)

### Server resources

### Hardware
- Ryzen 7 2700
- 16GB DDR4 2933 Mhz