## STAGE 1: Build
FROM node as builder

# Copy and install build dependencies
COPY package.json ./
RUN npm install aurelia-cli -g && npm i

# Copy all files and run build
WORKDIR /app
COPY . .
RUN au build --env prod

## STAGE 2: Deploy
FROM nginx:alpine

## Copy our nginx config and make it default
COPY nginx.conf /etc/nginx/conf.d/default.conf

## Remove default nginx site
RUN rm -rf /usr/share/nginx/html/*

COPY --from=builder /app/dist /usr/share/nginx/html
