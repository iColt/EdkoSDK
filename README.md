🔐 Cryptography Learning Roadmap

A structured, beginner-friendly path to understanding real-world cryptography

Welcome!
This repository is a complete learning guide and resource hub for anyone who wants to understand core cryptographic concepts—from the absolute basics to modern real-world algorithms used in HTTPS, blockchain, JWTs, and more.
Whether you're a student, software engineer, or security enthusiast, this roadmap gives you a clear path, curated explanations, coding exercises, and external references in a format that can be followed step-by-step.

📘 Table of Contents

Introduction
Why Learn Cryptography?
Prerequisites

Roadmap Overview

Module 1 — Foundations
Module 2 — Symmetric Cryptography
Module 3 — Asymmetric Cryptography
Module 4 — Hashing & Integrity
Module 5 — Authentication & Key Exchange
Module 6 — Real-World Cryptography
Module 7 — Advanced Topics

Recommended Books & Resources
Project Ideas
License

🧭 Introduction

Cryptography is everywhere—your browser, your phone, your password manager, online banking, messaging apps, and even blockchain networks.
This repository teaches cryptography from first principles with a focus on:
clarity
practicality
modern algorithms
hands-on implementation examples

You do not need advanced math knowledge to follow this roadmap.

⭐ Why Learn Cryptography?

It helps you write secure applications
It improves your understanding of authentication and secure communication
It's essential in modern engineering: HTTPS, JWT, OAuth, blockchain, cloud security
It’s fun, deep, and intellectually rewarding

📚 Prerequisites

Basic understanding of:
Variables, loops, functions
Any programming language (C#, Python, Java, JavaScript, etc.)
Optional but helpful: discrete math basics (modular arithmetic)

🗺 Roadmap Overview

This roadmap is divided into seven learning modules:
Foundations
Symmetric Cryptography
Asymmetric Cryptography
Hashing & Integrity
Authentication & Key Exchange
Real-World Cryptography
Advanced Topics

Each module includes:

✔ Explanation
✔ Visual intuition
✔ Practical coding exercises
✔ Recommended reading

Module 1 — Foundations
📌 Topics Covered

What is cryptography?
Terminology: plaintext, ciphertext, keys ✔
Threat models
Shannon’s principles
Types of cryptography (symmetric/asymmetric/hashing)

🏗 Exercises

Implement a simple Caesar cipher
Implement Vigenère cipher
Break Caesar using frequency analysis

Module 2 — Symmetric Cryptography
📌 Topics Covered

Stream ciphers vs block ciphers
AES (Advanced Encryption Standard)
Encryption modes: ECB, CBC, CFB, OFB, CTR, GCM
Padding (PKCS#7)

🧪 Exercises

Implement AES-CBC encryption/decryption
Demonstrate why ECB is insecure
Encrypt JSON files using AES-GCM

Module 3 — Asymmetric Cryptography
📌 Topics Covered

Public vs private keys
RSA
Modular exponentiation
Digital signatures
Elliptic Curve Cryptography (ECC) basics

🧪 Exercises

Implement RSA key generation
Use RSA to encrypt a symmetric AES key
Verify a digital signature

Module 4 — Hashing & Integrity
📌 Topics Covered

Properties of hash functions
SHA-256
HMAC
Password hashing (bcrypt, PBKDF2, Argon2)

🧪 Exercises

Hash a file using SHA-256
Build an HMAC implementation
Hash passwords using PBKDF2

Module 5 — Authentication & Key Exchange
📌 Topics Covered

TLS handshake
Diffie–Hellman key exchange
Certificates & Certificate Authorities
Message authentication vs encryption

🧪 Exercises

Implement a simplified Diffie–Hellman exchange
Parse and inspect an X.509 certificate
Demonstrate a MITM attack without authentication

Module 6 — Real-World Cryptography
📌 Topics Covered

JWT signing & verification
HTTPS internals
OAuth basics
Secure password storage
Cryptography in databases (TDE)
Cryptography in messaging apps (Signal protocol overview)

🧪 Exercises

Sign & verify JWTs using RS256
Create an HTTPS server and inspect TLS handshake
Encrypt a local secrets file

Module 7 — Advanced Topics
📌 Topics Covered

Zero-Knowledge Proofs
Homomorphic encryption
Secure Multi-Party Computation
Post-quantum cryptography (Kyber, Dilithium)

🧪 Exercises

Implement a toy Zero-Knowledge proof (Schnorr protocol)
Use a PQC library to generate post-quantum keys

📚 Recommended Books & Resources
Books

Serious Cryptography — Jean-Philippe Aumasson
Cryptography Engineering — Schneier, Ferguson, Kohno
Understanding Cryptography — Paar & Pelzl
Applied Cryptography — Bruce Schneier

Online

Stanford Crypto I (free)
Cryptopals Challenges
NIST FIPS publications
OpenSSL documentation
Web Security Academy (PortSwigger)

💡 Project Ideas

Here are some great real-world projects you can build:

Beginner
AES file encryptor
JWT token generator/validator
Password hashing CLI tool

Intermediate
HTTPS-like secure communication channel
RSA + AES hybrid encryption protocol
Simple encrypted messaging tool

Advanced
Build your own Certificate Authority
Implement SRP (Secure Remote Password) protocol
Implement a toy blockchain with digital signatures

📄 License

MIT License.
Do whatever you want—just be safe and don't invent your own cryptography 😉.
