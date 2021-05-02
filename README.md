# DockerDemo
Publish the sample code to create a docker image 

With Docker

To start the application

Step 1: Create docker network
docker network create mongo-network 

Step 2: start mongodb
docker run -d -p 27017:27017 -e MONGO_INITDB_ROOT_USERNAME=admin -e MONGO_INITDB_ROOT_PASSWORD=password --name mongodb --net mongo-network mongo    

Step 3: start mongo-express
docker run -d -p 8081:8081 -e ME_CONFIG_MONGODB_ADMINUSERNAME=admin -e ME_CONFIG_MONGODB_ADMINPASSWORD=password --net mongo-network --name mongo-express -e ME_CONFIG_MONGODB_SERVER=mongodb mongo-express   
NOTE: creating docker-network in optional. You can start both containers in a default network. In this case, just emit --net flag in docker run command

Step 4: open mongo-express from browser
http://localhost:8081

Step 5: create user-account db and users collection in mongo-express

Step 6: Start your dotnet core application by pressing the play button on visual studio

Step 7: Build docker image of the applicaiton, go to the path where dockerfile is stored and run the following command - docker build -t consoleapp .

Step 8: Run the docker image - docker run -d consoleapp --net mongo-network 

How to push your image to Azure Container Registry.

1. create a Container Registry on Azure
2. Login to it using docker login
3. Build your image on local using docker build -t [Image Name] .
4. tag your image to the newly created COntainer Registry docker tag hello-world swaroopdocker.azurecr.io/hello-world
5. Push your image to Container Registry docker push swaroopdocker.azurecr.io/hello-world

Create this app in single step.

1.go to the directory where docker-compose.yaml file is stored
2.Run the following command docker-compose -f docker-compose.yaml up
3.Thats it you now how mongo, mongo express and dotnet console app running on your machine.

