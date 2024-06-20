FROM openjdk:11-jre-slim
COPY target/car-rental-app.jar /app/car-rental-app.jar
ENTRYPOINT ["java", "-jar", "/app/car-rental-app.jar"]
