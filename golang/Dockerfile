FROM golang:1.22.3-alpine AS build

WORKDIR /app

COPY  go.mod go.sum ./

RUN go mod download && \
    go mod verify

COPY . .

RUN go build -o build/fizzbuzz

FROM scratch

WORKDIR /app

COPY --from=build /app/build/fizzbuzz .
COPY --from=build /app/templates/index.html templates/

EXPOSE 8080

CMD ["./fizzbuzz", "serve"]

