FROM python:3.10-bullseye

WORKDIR /app

COPY . .

RUN python -m venv ./.venv && \
    . ./.venv/bin/activate && \
    pip install -r requirements/freeze_requirements.txt

EXPOSE 5000

ENTRYPOINT [".venv/bin/uvicorn", "spaceship.main:app"]

CMD ["--host=0.0.0.0", "--port=5000"]