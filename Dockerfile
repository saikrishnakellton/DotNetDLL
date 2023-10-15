# Use an official Python runtime as a parent image
FROM python:3.8-slim

# Set the working directory in the container
WORKDIR /app

# Copy the current directory contents into the container at /app
COPY . /app

# Install the Mono runtime
RUN apt-get update && apt-get install -y mono-complete
# RUN apt-get install mono-vbnc


# Install any needed packages specified in requirements.txt
RUN pip install --trusted-host pypi.python.org -r requirements.txt

# Set the PYTHONNET_PYDLL environment variable
ENV PYTHONNET_PYDLL=/usr/lib/x86_64-linux-gnu/libpython3.8.so

# Run script.py when the container launches
# CMD ["python", "main.py"]
CMD ["python", "-m", "ipdb", "main.py"]

