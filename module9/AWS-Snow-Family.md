# AWS Snow Family
The AWS Snow Family is a collection of physical devices that help to physically transport up to exabytes of data into and out of AWS

composed of:
Snowcone
Snowball
Snowmobile

Each device has different capacity points and most include built-in computing capabilities. They're integrated with AWS security, monitoring, storage management, and computing capbilities.

## Snowcone
small, rugged edge computing and data transfer device
2 CPUs
4GB of memory
14TB usable storage

## Snowball
two options:
> Snowball Edge Storage Optimized
- Storage
80 TB HDD
1 TB SSD for block volumes

- Compute
40 vCPUs
80 GiB of memory to support EC2 sbe1 instances

> Snowball Edge Compute Optimized
- Storage
80 TB HDD
28 TB NVMe SSD for block volumes

- Compute
104 vCPUs
416 GiB of memory
optional NVIDIA Tesla V100 GPU
Devices run Amazon EC2 sbe-c and sbe-g instances, which are equivalent to C5, M5a, G3, and P3 instances.


## Snowmobile
Exabyte scale data transfer service
45-foot long ruggedized shipping container pulled by a semi trailer truck

100 petabytes of data per Snowmobile

