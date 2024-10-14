FROM alpine:latest

RUN echo "echo #!/bin/sh" >> /test.sh && \
    echo "echo Test Image" >> /test.sh && \
    chmod +x /test.sh

CMD [ "sh", "/test.sh" ]