FROM alpine:latest AS alpine-base

RUN echo "echo #!/bin/sh" >> /test.sh && \
    echo "cat /etc/os-release" >> /test.sh && \
    echo "echo Test Image" >> /test.sh && \
    chmod +x /test.sh

CMD [ "sh", "/test.sh" ]

FROM ubuntu:latest AS ubuntu-base

RUN echo "echo #!/bin/sh" >> /test.sh && \
    echo "cat /etc/os-release" >> /test.sh && \
    echo "echo Test Image" >> /test.sh && \
    chmod +x /test.sh

CMD [ "sh", "/test.sh" ]