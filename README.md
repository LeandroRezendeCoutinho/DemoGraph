## Benchmark Hot Chocolate GraphQL engine in memory

### Demo from Get started with Hot Chocolate V 11

### How to test
- Install autocannon tool
- npm i autocannon -g

### Command
- autocannon -m 'POST' -b '{ "query": "{ book { title author { name } } }" }' -H "Content-Type: application/json" http://localhost:5000/graphql

### Results

### Server resources

### Hardware
- Ryzen 7 2700
- 16GB DDR4 2933 Mhz