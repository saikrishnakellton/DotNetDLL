# Use an official Python runtime as a parent image
FROM ubuntu:23.10

RUN apt-get update && \
    apt-get install -y python3 python3-pip


# Set the working directory in the container
WORKDIR /app

# Copy the current directory contents into the container at /app
COPY . /app

# Install the Mono runtime
RUN apt-get update && apt-get install -y mono-complete
# RUN apt-get install mono-vbnc


RUN apt-get update && \
    apt-get install -y python3-venv

# Recreate the virtual environment
RUN python3 -m venv env
ENV PATH="/app/env/bin:$PATH"

# RUN source env/bin/activate

RUN  pip install pythonnet
# Install any needed packages specified in requirements.txt
# RUN pip install --trusted-host pypi.python.org -r requirements.txt
RUN pip3 install -r requirements.txt

# Set the PYTHONNET_PYDLL environment variable
ENV PYTHONNET_PYDLL=/usr/lib/x86_64-linux-gnu/libpython3.8.so

# Expose port 8990 to the outside world
EXPOSE 8990

# Define environment variable
ENV NAME World

# Run script.py when the container launches
# CMD ["python", "main.py"]
CMD ["python", "app.py"]

